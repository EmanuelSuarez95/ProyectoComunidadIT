using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class Dia
    {
        int hora { get; set; }
        int minutos { get; set; }

        private Dia()
        {

        }

        Dia Lunes = new Dia();
        Dia Martes = new Dia();
        Dia Miercoles = new Dia();
        Dia Jueves = new Dia();
        Dia Viernes = new Dia();
        Dia Sabado = new Dia();
    }
}