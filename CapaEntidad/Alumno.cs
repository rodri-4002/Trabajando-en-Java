using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class Alumno : Persona
    {
        private int codigo;
        private int telefono;

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public int Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string DevolverDatosAlumno()
        {
            return "Codigo: " + this.Codigo + " Apellidos: " + this.Apellidos + " Nombres: " +
            this.Nombre + " Edad: " + Convert.ToString(this.Edad) + " Telefono: " +
            this.Telefono;
        }
    }

}