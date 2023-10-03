using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class InfoReparacionMantencion
    {
        private string patente;
        private string kilometraje;
        private string inspeccion;
        private string trabajo;
        private string fecha;
        private List<Piezas> listaPiezas;

        public InfoReparacionMantencion(string nuevoPatente, string nuevoKilometraje, string nuevoInspeccion, string nuevoTrabajo, string nuevoFecha, List<Piezas> nuevoListaPiezas)
        {
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
    }
        //-------------------------------
    }

