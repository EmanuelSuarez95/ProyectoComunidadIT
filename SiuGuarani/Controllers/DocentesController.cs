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
            return View("Index");
        }
    }
}