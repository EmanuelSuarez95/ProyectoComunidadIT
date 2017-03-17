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
        public ActionResult IngresarAlumno(long usuario, string contraseña)
        {

            long usuarioDni = usuario;
            string usuarioContraseña = contraseña;
            List<Models.Alumno> listaAlumnos = (List<Models.Alumno>)Session["Alumnos"];
            if (listaAlumnos == null)
            {
                listaAlumnos = new List<Models.Alumno>();
            }
            Models.Alumno Ema = new Models.Alumno();
            Ema.dni = 39155502;
            Ema.pass = "chamaco";
            Ema.nombre = "Ema";
            listaAlumnos.Add(Ema);
            
            foreach (Models.Alumno alumno in listaAlumnos)
            {
                if (usuarioDni == alumno.dni)
                {
                    if (usuarioContraseña == alumno.pass)
                    {
                        ViewBag.alumno = alumno.nombre;
                        return View("Index");
                    }

                    else
                    {

                        ViewBag.mensaje = "La contraseña es incorrecta";
                        return View("/Views/Home/Index.cshtml");
                    }
                }
                else
                {
                    return View("/Views/Home/Index.cshtml");
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