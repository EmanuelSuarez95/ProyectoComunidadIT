using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class Docente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string pass { get; set; }
        public long telefono { get; set; }
        public string mail { get; set; }
        public List<Comision> comisionesACargo;
        public Carrera carrera;
    }
}