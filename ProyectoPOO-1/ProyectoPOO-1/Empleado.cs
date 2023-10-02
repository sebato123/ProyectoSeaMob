using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    internal class Empleado
    {
        private string nombre;
        private string rut;
        private string telefono;

        public Empleado(string nuevoNombre, string nuevoRut, string nuevoTelefono)
        {
            nombre = nuevoNombre;
            rut = nuevoRut;
            telefono = nuevoTelefono;
        }


        //Setters y Getters
        //----------------------------------------

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Rut
        {
            set { rut = value; }
            get { return rut; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        //---------------------------------------
    }
}
