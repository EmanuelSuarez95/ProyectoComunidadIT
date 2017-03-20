using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class AdministradorManager
    {
        public List<Administrador> ConsultarDatos()
        {
            List<Administrador> listaAdmin = new List<Administrador>();


            //1-Conectarse a bbdd
            SqlConnection conexion = new SqlConnection("Server=RIVER-PLATE;Database=SiuGuarani;Trusted_Connection=True;");

            //2- abrir conexion 

            conexion.Open();

            //3- Crear el query

            SqlCommand sentencia = conexion.CreateCommand();

            //4- realizamos la consulta

            sentencia.CommandText = "SELECT * FROM admin";
            SqlDataReader reader = sentencia.ExecuteReader();
            while (reader.Read()) //mientras haya un registro para leer
            {
                //creo el artículo, le completo los datos 
                Administrador admin = new Administrador();
                admin.dni = (string)reader["dni"];
                admin.pass = (string)reader["pass"];


                listaAdmin.Add(admin);
            }

            //CERRAR EL READER AL TERMINAR DE LEER LOS REGISTROS
            reader.Close();
            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();

            return listaAdmin;
        }
    }
}