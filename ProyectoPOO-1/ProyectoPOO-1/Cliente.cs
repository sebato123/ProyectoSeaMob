using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class Cliente
    {
        private string razonSocial;
        private string rut;
        private string direccion;
        private string telefono;
        private string email;

        //Constructor
        public Cliente(string nuevoRazonSocial, string nuevoRut, string nuevoDireccion, string nuevoTelefono, string nuevoEmail)
        {
            razonSocial = nuevoRazonSocial;
            rut = nuevoRut;
            direccion = nuevoDireccion;
            telefono = nuevoTelefono;
            email = nuevoEmail;
        }



        //Getters and Setters
        //-------------------------------
        public string RazonSocial
        {
            set { razonSocial = value; }
            get { return razonSocial; }
        }

        public string Rut
        {
            set { rut = value; }
            get { return rut; }
        }

        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        //-------------------------------
    }
}


