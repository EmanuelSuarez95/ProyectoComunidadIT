using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiuGuarani.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IngresarAlumno(string usuario, string contraseña)
        {

            string dni = usuario;
            string pass = contraseña;
            Models.AlumnoManager manager = new Models.AlumnoManager();
            List<Models.Alumno> listaAlumnos = manager.ConsultarDatos();
            foreach (Models.Alumno alumno in listaAlumnos)
            {
                if (alumno.dni == dni & alumno.pass == pass)
                {
                    
                    ViewBag.alumno = dni;
                    return View("Index");
                }

            }
            return View("/Views/Home/Index.cshtml");
        }
           

        public ActionResult InscripcionMaterias()
        {
            return View();
        }
        public ActionResult InscripcionExamenes()
        {
            return View();
        }
        public ActionResult InscripcionPracticas()
        {
            return View();
        }
    }
}