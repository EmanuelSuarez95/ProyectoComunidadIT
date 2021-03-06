﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class AlumnoManager
    {
        public void Agregar(Alumno alumno)
        {
            //1-Conexión.. a qué BBDD
            SqlConnection conexion = new SqlConnection("Server=RIVER-PLATE;Database=SiuGuarani;Trusted_Connection=True;");
            //2-nos conectamos
            conexion.Open();
            //3-creamos el objeto que nos permite escribir la sentencia
            SqlCommand sentencia = conexion.CreateCommand();
            //4-escribrimos la sentencia
            sentencia.CommandText = "insert into alumno (dni,nombre,apellido,mail,telefono) VALUES (@dni, @nombre, @apellido, @mail, @telefono)";
            //sentencia.Parameters.AddWithValue("@Fecha", articulo.Fecha);
            sentencia.Parameters.AddWithValue("@dni", alumno.dni);
            sentencia.Parameters.AddWithValue("@nombre" , alumno.nombre);
            sentencia.Parameters.AddWithValue("@apellido", alumno.apellido);
            sentencia.Parameters.AddWithValue("@mail", alumno.email);
            sentencia.Parameters.AddWithValue("@telefono", alumno.telefono);
            //5-Ejecutar!
            sentencia.ExecuteNonQuery();

            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();
        }

        public void Eliminar(Alumno alumno)
        {
            this.Eliminar(alumno.dni);
        }

        public void Eliminar(string dni)
        {
            //1-Conexión.. a qué BBDD
            SqlConnection conexion = new SqlConnection("Server=RIVER-PLATE;Database=SiuGuarani;Trusted_Connection=True;");
            //2-nos conectamos
            conexion.Open();
            //3-creamos el objeto que nos permite escribir la sentencia
            SqlCommand sentencia = conexion.CreateCommand();
            //4-escribrimos la sentencia
            sentencia.CommandText = "delete from alumno where Id = @Id";
            // Iguala @Id de la sentencia sql a la variable dni
            sentencia.Parameters.AddWithValue("@Id", dni);
            //5-Ejecutar!
            sentencia.ExecuteNonQuery();

            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();
        }

        public List<Alumno> ConsultarDatos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();


            //1-Conectarse a bbdd
            SqlConnection conexion = new SqlConnection("Server=RIVER-PLATE;Database=SiuGuarani;Trusted_Connection=True;");

            //2- abrir conexion 

            conexion.Open();

            //3- Crear el query

            SqlCommand sentencia = conexion.CreateCommand();

            //4- realizamos la consulta

            sentencia.CommandText = "SELECT * FROM alumno";
            SqlDataReader reader = sentencia.ExecuteReader();
            while (reader.Read()) //mientras haya un registro para leer
            {
                //creo el artículo, le completo los datos 
                Alumno alumno = new Alumno();
                alumno.dni = (string)reader["dni"];
                alumno.pass = (string)reader["pass"];


                listaAlumnos.Add(alumno);
            }

            //CERRAR EL READER AL TERMINAR DE LEER LOS REGISTROS
            reader.Close();
            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();

            return listaAlumnos;
        }

    }
}