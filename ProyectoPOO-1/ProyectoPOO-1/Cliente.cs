using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class Cliente
    {
        private string razonSocial;
        private string rutCliente;
        private string direccion;
        private string telefonoCliente;
        private string email;

        //Constructor
        public Cliente(string nuevoRazonSocial, string nuevoRutCliente, string nuevoDireccion, string nuevoTelefonoCliente, string nuevoEmail)
        {
            razonSocial = nuevoRazonSocial;
            rutCliente = nuevoRutCliente;
            direccion = nuevoDireccion;
            telefonoCliente = nuevoTelefonoCliente;
            email = nuevoEmail;
        }



        //Getters and Setters
        //-------------------------------
        public string RazonSocial
        {
            set { razonSocial = value; }
            get { return razonSocial; }
        }

        public string RutCliente
        {
            set { rutCliente = value; }
            get { return rutCliente; }
        }

        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public string TelefonoCliente
        {
            set { telefonoCliente = value; }
            get { return telefonoCliente; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        //-------------------------------

        public void ObtenerInfoCliente()
        {
            Console.WriteLine("La Razon Social es: "+ razonSocial);
            Console.WriteLine("El Rut es: "+ rutCliente);
            Console.WriteLine("La Direccion es: "+ direccion);
            Console.WriteLine("El Telefono es: " + telefonoCliente);
            Console.WriteLine("El Email es: "+  email);

            Console.ReadKey();
        }
    }
}


