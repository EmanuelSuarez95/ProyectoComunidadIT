using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiuGuarani.Models
{
    public class Administrador
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string pass;
        public List<Alumno> listaAlumnos;
        public List<Materia> listaMaterias;
        public List<Docente> listaDocentes;
        public List<Carrera> listaCarreras;
        public List<Comision> listaComisiones;
        public List<Instituto> listaInstitutos;

        private Administrador(string dni, string pass,string nombre, string apellido)
        {
            dni = this.dni;
            pass = this.pass;
            nombre = this.nombre;
            apellido = this.apellido;
        }

        Administrador admin = new Administrador("39155502","39155502","Emanuel","Suárez");

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