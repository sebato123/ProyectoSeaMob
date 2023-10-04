using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{

    internal class Vehiculo
    {
        private string marca;
        private string patente;
        private string modelo;
        private string color;
        private int ano;


        //Constructor
        public Vehiculo(string nuevoMarca, string nuevoPatente, string nuevoModelo, string nuevoColor, int nuevoAno)
        {
            marca = nuevoMarca;
            patente = nuevoPatente;
            modelo = nuevoModelo;
            color = nuevoColor;
            ano = nuevoAno;
        }

        //Setters y Getters
        //----------------------------------------

        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }
        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        public string Color
        {
            set { color = value; }
            get { return color; }
        }

        public int Ano
        {
            set { ano = value; }
            get { return ano; }

        }
        //----------------------------------------

        public void ObtenerInformacion()
        {
            Console.WriteLine("La patente es: " + patente);
            Console.WriteLine("La marca es: " + marca);
            Console.WriteLine("El modelo es: " + modelo);
            Console.WriteLine("El color es: " + color);
            Console.WriteLine("El año es: " + ano);
            Console.ReadKey();
        }
    } 
    }
