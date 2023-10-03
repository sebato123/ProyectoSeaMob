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

                AgregarPiezas();
                AgregarPiezas();
                EliminarPiezas();
                ListarPiezas();




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

        private void EliminarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehiculo a eliminar:");
            string patente = Console.ReadLine();
            int index = ObtenerVehiculo(patente);

            vehiculos.RemoveAt(index);
            Console.WriteLine("El vehiculo se ha eliminado correctamente");
        }

        private void ListarVehiculo()
        {
            int n = 1;
            Console.Clear();
            foreach (Vehiculo auto in vehiculos)
            {
                Console.WriteLine("---------------- Vehiculo " + n + " -----------------");
                auto.ObtenerInformacion();
                n++;
            }
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
            Console.WriteLine("No se pudo encontrar el vehiculo");
            return 0;
        }


        //------------------------------------------------------------
    

    //------------------------PARTES  Y PIEZAS ------------------------

    private void AgregarPiezas()
    {
        Console.Clear();
        Console.WriteLine("Informacion de la nueva Pieza/Parte");

        string identificadorUnico = Console.ReadLine();
        string marcaPieza = Console.ReadLine();
        string proveedor = Console.ReadLine();
        string costoUnitario = Console.ReadLine();

        Piezas pieza = new Piezas(identificadorUnico, marcaPieza, proveedor, costoUnitario);

        piezas.Add(pieza);
    }
        
        private void EditarPiezas()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehiculo a modificar:");
            string patente = Console.ReadLine();
            int index = ObtenerVehiculo(patente);
            vehiculos[index].ObtenerInformacion();




        }


        private void EliminarPiezas()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el identificador unico de la pieza/parte a eliminar:");
            string id = Console.ReadLine();
            int index = ObtenerPiezas(id);

            piezas.RemoveAt(index);
            Console.WriteLine("La pieza se ha eliminado correctamente");
        }


        private void ListarPiezas()
        {
            int n = 1;
            Console.Clear();
            foreach (Piezas pieza in piezas)
            {
                Console.WriteLine("---------------- Pieza " + n + " -----------------");
                pieza.ObtenerInformacion();
                n++;
            }
        }

        private int ObtenerPiezas(string id)
        {
            foreach (Piezas pieza in piezas)
            {
                if (id == pieza.IdentificadorUnico)
                {
                    return piezas.IndexOf(pieza);
                }
            }
            Console.WriteLine("No se pudo encontrar la Pieza/Parte");
            return 0;
        }

        //----------------------------------------------------------------------------------

        //--------------------------------MANTENIMIENTO------------------------





    }
}


    

