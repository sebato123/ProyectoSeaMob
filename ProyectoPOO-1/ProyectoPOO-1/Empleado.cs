using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class Empleado
    {
        private string nombre;
        private string rutEmpleado;
        private string telefonoEmpleado;

        public Empleado(string nuevoNombre, string nuevoRutEmpleado, string nuevoTelefonoEmpleado)
        {
            nombre = nuevoNombre;
            rutEmpleado = nuevoRutEmpleado;
            telefonoEmpleado = nuevoTelefonoEmpleado;
        }


        //Setters y Getters
        //----------------------------------------

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string RutEmpleado
        {
            set { rutEmpleado = value; }
            get { return rutEmpleado; }
        }

        public string TelefonoEmpleado
        {
            set { telefonoEmpleado = value; }
            get { return telefonoEmpleado; }
        }

        //---------------------------------------

        public void ObtenerInfoEmpleado()
        {
            Console.WriteLine("El Nombre es: " + nombre);
            Console.WriteLine("El Rut es: " + rutEmpleado);
            Console.WriteLine("El Telefono es: " + telefonoEmpleado);
            

            Console.ReadKey();
        }
    }
}
