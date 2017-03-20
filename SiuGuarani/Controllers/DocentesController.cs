using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiuGuarani.Controllers
{
    public class DocentesController : Controller
    {
        // GET: Docentes
        public ActionResult IngresarDocente(string usuario, string contraseña)
        {
            string dni = usuario;
            string pass = contraseña;
            Models.DocenteManager manager = new Models.DocenteManager();
            List<Models.Docente> listaDocentes = manager.ConsultarDatos();
            foreach (Models.Docente docente in listaDocentes)
            {
                if (docente.dni == dni & docente.pass == pass)
                {
                    return View("Index");
                }

            }
            return View("/View/Home/Index.cshtml");
        }
    }
}