using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiuGuarani.Controllers
{
    public class AdminController : Controller
    {
        // Ingresar como Administrador
        public ActionResult IngresarAdmin(string usuario, long contraseña)
        {
            return View("Index");
        }
        //Ir a la vista que agrega elementos
        public ActionResult AlumnoNuevo()
        {
            return View("AgregarAlumno");
        }
        public ActionResult CarreraNueva()
        {
            return View("AgregarCarrera");
        }
        public ActionResult ComisionNueva()
        {
            return View("AgregarComision");
        }
        public ActionResult InstitutoNuevo()
        {
            return View("AgregarInstituto");
        }
        public ActionResult MateriaNueva()
        {
            return View("AgregarMateria");
        }
        public ActionResult DocenteNuevo()
        {
            return View("AgregarDocente");
        }

        //Formulario para agregar alumnos
        public ActionResult AgregarAlumno(string nombre,string apellido, long dni, string carrera, long telefono,string mail)
        {
            Models.Alumno alumno = new Models.Alumno();
            alumno.dni = dni;
            alumno.nombre = nombre;
            alumno.apellido = apellido;
            alumno.email = mail;
            alumno.telefono = telefono;


            Models.AlumnoManager alumnoManager = new Models.AlumnoManager();
            alumnoManager.Insertar(alumno);
                return View("Index");

        }
        //Formulario para agregar carreras
        public ActionResult AgregarCarrera(string nombre, string instituto)
        {
            Models.Carrera carrera = new Models.Carrera();
            carrera.Nombre = instituto;
            return View("Index");
        }
        //Formulario para agregar comisions
        public ActionResult AgregarComision()
        {
            Models.Comision comision = new Models.Comision();
            return View("Index");
        }
        //Formulario para agregar docentes
        public ActionResult AgregarDocente(string nombre, string apellido, long telefono, string mail, long dni)
        {
            Models.Docente docente = new Models.Docente();
            docente.nombre = nombre;
            docente.apellido = apellido;
            docente.telefono = telefono;
            docente.mail = mail;
            docente.dni = dni;

            return View("Index");
        }
        //Formulario para agregar instituto
        public ActionResult AgregarInstituto(string nombre)
        {
            Models.Instituto instituto = new Models.Instituto();
            instituto.nombre = nombre;
            return View("Index");
        }
        //Formulario para agregar materias
        public ActionResult AgregarMateria(string nombre,float cargaHorario)
        {
            Models.Materia materia= new Models.Materia();
            materia.nombre= nombre;
            return View("Index");
        }

    }

}