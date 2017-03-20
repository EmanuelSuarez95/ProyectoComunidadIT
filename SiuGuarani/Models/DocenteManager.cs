using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class DocenteManager
    {
        public void Agregar(Docente docente)
        {
            //1-Conexión.. a qué BBDD
            SqlConnection conexion = new SqlConnection("Server=RIVER-PLATE;Database=SiuGuarani;Trusted_Connection=True;");
            //2-nos conectamos
            conexion.Open();
            //3-creamos el objeto que nos permite escribir la sentencia
            SqlCommand sentencia = conexion.CreateCommand();
            //4-escribrimos la sentencia
            sentencia.CommandText = "insert into docente (dni,nombre,apellido,mail,telefono) VALUES (@dni, @nombre, @apellido, @mail, @telefono)";
            //sentencia.Parameters.AddWithValue("@Fecha", articulo.Fecha);
            sentencia.Parameters.AddWithValue("@dni", docente.dni);
            sentencia.Parameters.AddWithValue("@nombre", docente.nombre);
            sentencia.Parameters.AddWithValue("@apellido", docente.apellido);
            sentencia.Parameters.AddWithValue("@mail", docente.mail);
            sentencia.Parameters.AddWithValue("@telefono", docente.telefono);
            //5-Ejecutar!
            sentencia.ExecuteNonQuery();

            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();
        }

        public void Eliminar(Docente docente)
        {
            this.Eliminar(docente.dni);
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
            sentencia.CommandText = "delete from docente where Id = @Id";
            // Iguala @Id de la sentencia sql a la variable dni
            sentencia.Parameters.AddWithValue("@Id", dni);
            //5-Ejecutar!
            sentencia.ExecuteNonQuery();

            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();
        }

        public List<Docente> ConsultarDatos()
        {
            List<Docente> listaDocentes = new List<Docente>();


            //1-Conectarse a bbdd
            SqlConnection conexion = new SqlConnection("Server=RIVER-PLATE;Database=SiuGuarani;Trusted_Connection=True;");

            //2- abrir conexion 

            conexion.Open();

            //3- Crear el query

            SqlCommand sentencia = conexion.CreateCommand();

            //4- realizamos la consulta

            sentencia.CommandText = "SELECT * FROM docente";
            SqlDataReader reader = sentencia.ExecuteReader();
            while (reader.Read()) //mientras haya un registro para leer
            {
                //creo el artículo, le completo los datos 
                Docente docente= new Docente();
                docente.dni = (string)reader["dni"];
                docente.pass = (string)reader["pass"];


                listaDocentes.Add(docente);
            }

            //CERRAR EL READER AL TERMINAR DE LEER LOS REGISTROS
            reader.Close();
            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();

            return listaDocentes;
        }
    }
}