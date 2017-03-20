using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class Administrador
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        public string dni { get; set; }
        public string pass { get; set; }
        public List<Alumno> listaAlumnos;
        public List<Materia> listaMaterias;
        public List<Docente> listaDocentes;
        public List<Carrera> listaCarreras;
        public List<Comision> listaComisiones;
        public List<Instituto> listaInstitutos;

        public Administrador()
        {

        }
        

        public void nuevoAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public void nuevoInstituto(Instituto instituto)
        {
            listaInstitutos.Add(instituto);
        }
        public void nuevoDocente(Docente docente)
        {
            listaDocentes.Add(docente);
        }
        public void nuevaCarrera(Carrera carrera)
        {
            listaCarreras.Add(carrera);
        }
        public void nuevaMateria(Materia materia)
        {
            listaMaterias.Add(materia);
        }

    }
}