using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class Comision
    {
        string id { get; set; }
        Docente docente { get; set; }
        Materia materia { get; set; }

    }
}