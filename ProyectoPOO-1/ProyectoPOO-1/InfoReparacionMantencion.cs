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
        private List<Piezas> listaPiezas;
       

        public InfoReparacionMantencion(string nuevoPatente, string nuevoKilometraje, string nuevoInspeccion, string nuevoTrabajo, string nuevoFecha, List<Piezas> nuevoListaPiezas)
        {
            //cliente = nuevoCliente;
            patente = nuevoPatente;
            kilometraje = nuevoKilometraje;
            inspeccion = nuevoInspeccion;
            trabajo = nuevoTrabajo;
            fecha = nuevoFecha;
            listaPiezas = nuevoListaPiezas;
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

        //Ingresar bool mantencion y fecha de entrega

        public void ObtenerInformacion()
        {
            Console.WriteLine("La patente es: " + patente);
            Console.WriteLine("El kilometraje es: " + kilometraje);
            Console.WriteLine("La inspeccion visual es: " + inspeccion);
            Console.WriteLine("El trabajo a realizar es: " + trabajo);
            Console.WriteLine("La fecha de ingreso del vehiculo es: " + fecha);
            Console.WriteLine("La lista de piezas es: " +  listaPiezas);
            foreach (Piezas pieza in listaPiezas)
            {
                pieza.ObtenerInformacion();
            }
        }

    }
    }

