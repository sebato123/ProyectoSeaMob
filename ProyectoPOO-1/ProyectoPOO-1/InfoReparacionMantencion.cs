using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class InfoReparacionMantencion
    {
        private Empleado empleado;
        private string patente;
        private string kilometraje;
        private string inspeccion;
        private string trabajo;
        private string fecha;
        private bool entregado;
        private List<Piezas> listaPiezas;
        private string fechaEntrega;
       

        public InfoReparacionMantencion(string nuevoPatente, string nuevoKilometraje, string nuevoInspeccion, string nuevoTrabajo, string nuevoFecha, List<Piezas> nuevoListaPiezas, bool nuevoEntregado, Empleado nuevoEmpleado)
        {       
            patente = nuevoPatente;
            kilometraje = nuevoKilometraje;
            inspeccion = nuevoInspeccion;
            trabajo = nuevoTrabajo;
            fecha = nuevoFecha;
            listaPiezas = nuevoListaPiezas;
            entregado = nuevoEntregado;
            empleado = nuevoEmpleado;

            if (entregado)
            {
                DateTime fechaIngreso = DateTime.Parse(fecha);
                while (true)
                {
                    Console.WriteLine("Ingrese la fecha de entrega del vehiculo en formato AAAA-MM-DD, recuerda que la fecha de entrega no puede ser menor a la de ingreso:");
                    string fechaEntregaInput = Console.ReadLine();

                    if (DateTime.TryParseExact(fechaEntregaInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaEntregaValue) && (fechaIngreso <= fechaEntregaValue))
                    {
                        fechaEntrega = fechaEntregaInput; // Asignar el valor a la variable de instancia
                        Console.WriteLine("Fecha ingresada válida: " + fechaEntregaValue.ToString("yyyy-MM-dd"));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fecha ingresada no válida.");
                    }
                }
            }



        }

        //Getters and Setters
        //-------------------------------

        public string Patente
        {
            set { patente = value; }
            get { return patente; }
        }

        public Empleado Empleado
        {
            set { empleado = value; }
            get { return empleado;  }
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
        public string FechaIngreso
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

        public string FechaEntrega
        {
            set { fechaEntrega = value; }
            get { return fechaEntrega; }
        }

     //--------------------------------------------

        public int DiferenciaFechas()
        {
            //Calcula diferencia entre la fecha de entrega y la de ingreso en Dias usando TimeSpan y DateTime.Parse
            if (entregado == true)
            {
                DateTime fechaIngreso = DateTime.Parse(fecha);
                DateTime fechaEntrega1 = DateTime.Parse(fechaEntrega);
                TimeSpan diferencia = fechaEntrega1 - fechaIngreso;
                return diferencia.Days;
            }
            else
            {
                return 0;
            }
        }




        public void ObtenerInformacion()
        {
            Console.WriteLine("La patente es: " + patente);
            Console.WriteLine("El empleado a cargo de la mantencion es: " + empleado.Nombre);
            Console.WriteLine("El kilometraje es: " + kilometraje);
            Console.WriteLine("La inspeccion visual es: " + inspeccion);
            Console.WriteLine("El trabajo a realizar es: " + trabajo);
            Console.WriteLine("La fecha de ingreso del vehiculo es: " + fecha);
            if (entregado == true)
            {
                Console.WriteLine("El vehiculo fue entregado en " + fechaEntrega);
            }
            else
            {
                Console.WriteLine("El vehiculo no ha sido entregado.");
            }

            if (listaPiezas.Count == 0)
            {
                Console.WriteLine("La lista de piezas esta vacia.");
            }

            //Accede a la lista de piezas e imprime la informacion.
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
        }

    }
    }

