﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiuGuarani.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult IngresarAdmin(string usuario, string contraseña)
        {
            return View("Index");
        }
    }
}