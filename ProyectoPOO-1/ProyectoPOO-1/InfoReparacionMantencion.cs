using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class InfoReparacionMantencion
    {
        //private Cliente cliente;
        private string patente;
        private string kilometraje;
        private string inspeccion;
        private string trabajo;
        private string fecha;
        private bool entregado;
        private List<Piezas> listaPiezas;
        private int fechaEntrega;
       

        public InfoReparacionMantencion(string nuevoPatente, string nuevoKilometraje, string nuevoInspeccion, string nuevoTrabajo, string nuevoFecha, List<Piezas> nuevoListaPiezas, bool nuevoEntregado)
        {       
            patente = nuevoPatente;
            kilometraje = nuevoKilometraje;
            inspeccion = nuevoInspeccion;
            trabajo = nuevoTrabajo;
            fecha = nuevoFecha;
            listaPiezas = nuevoListaPiezas;
            entregado = nuevoEntregado;
            if (entregado == true) 
            {
                Console.WriteLine("Ingrese la fecha de entrega en la siguiente formula AAAA/MM/DD");
                fechaEntrega = int.Parse(Console.ReadLine()); 
            }

        }

        //Getters and Setters
        //-------------------------------

        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }
        public string Kilometraje
        {
            set { kilometraje = value; }
            get { return kilometraje; }
        }
        public string Inspeccion
        {
            set { inspeccion = value; }
            get { return inspeccion; }
        }
        public string Trabajo
        {
            set { trabajo = value; }
            get { return trabajo; }
        }
        public string Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public List<Piezas> ListaPiezas
        {
            set { listaPiezas = value; }
            get { return listaPiezas; }
        }

        public bool Entregado
        {
            set { entregado = value; }
            get { return entregado; }
        }

        public int FechaEntrega
        {
            set { fechaEntrega = value; }
            get { return fechaEntrega; }
        }

     //--------------------------------------------

        public void ObtenerInformacion()
        {
            Console.WriteLine("La patente es: " + patente);
            Console.WriteLine("El kilometraje es: " + kilometraje);
            Console.WriteLine("La inspeccion visual es: " + inspeccion);
            Console.WriteLine("El trabajo a realizar es: " + trabajo);
            Console.WriteLine("La fecha de ingreso del vehiculo es: " + fecha);

            if (listaPiezas.Count == 0)
            {
                Console.WriteLine("La lista de piezas esta vacia.");
            }

            else
            {
                Console.WriteLine("La lista de piezas es: ");
                int n = 0;
                foreach (Piezas pieza in listaPiezas)
                {
                    n++;
                    Console.WriteLine("---------- Pieza " + n + "-----------");
                    pieza.ObtenerInformacion();
                    Console.WriteLine();
                }
            }

            if(entregado == true)
            {
                Console.WriteLine("El vehiculo fue entregado en"); // APRENDER A USAR DATATIME, se ve util
            }
            else
            {
                Console.WriteLine("El vehiculo no ha sido entregado.");
            }
        }

    }
    }

