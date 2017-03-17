using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class AlumnoManager
    {
        public void Insertar(Alumno alumno)
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

    }
}