using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class Materia
    {
        public string nombre { get; set; }
        public float cargaHoraria { get; set; }
        public float cargaHorariaTotal { get; set; }
        public Docente coordinador { get; set; }

    }
}