using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class Alumno
    {
        public long dni { get; set; }
        public string pass { get; set; }
        public Carrera carrera { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public long telefono { get; set; }
        public List<Comision> comisionesInscriptas;
    }
}