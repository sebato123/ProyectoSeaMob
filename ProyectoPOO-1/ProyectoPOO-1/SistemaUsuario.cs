using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class SistemaUsuario
    {
        private List<Empleado> empleados;
        private List<Cliente> clientes;
        private List<Vehiculo> vehiculos;
        private List<InfoReparacionMantencion> info;
        private List<Piezas> piezas;


        public SistemaUsuario()
        {
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            vehiculos = new List<Vehiculo>();
            info = new List<InfoReparacionMantencion>();
            piezas = new List<Piezas>();
        }

        public void Sistema()
        {
            bool salir = false;

            while (!salir) 
            {

                AgregarVehiculo();
                EditarVehiculo();

            
            
            
            }


        }
    

        //-------------------VEHICULOS-------------------------------
        private void AgregarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Informacion del nuevo vehiculo: ");

            string marca = Console.ReadLine();
            string patente = Console.ReadLine(); ;
            string modelo = Console.ReadLine(); ;
            string color = Console.ReadLine(); ;
            int ano = int.Parse(Console.ReadLine());  

            Vehiculo vehiculo = new Vehiculo(marca, patente, modelo, color, ano);

            vehiculos.Add(vehiculo);
        }
        private void EditarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehiculo a modificar:");
            string patente = Console.ReadLine();

            int index = ObtenerVehiculo(patente);

            vehiculos[index].ObtenerInformacion();  
            



        }
        private int ObtenerVehiculo(string patente)
        {
            foreach (Vehiculo auto in vehiculos)
            {
                if (patente == auto.Patente)
                {
                    return vehiculos.IndexOf(auto);
                }
            }
            return 0;
        }


        //------------------------------------------------------------
    }

    }


    

