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

                AgregarCliente();
                MostrarCliente();
                EliminarCliente();
                MostrarCliente();


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


























































































        //seaaaa Cliente
        private void AgregarCliente()
        {
            Console.Clear();
            Console.WriteLine("Informacion del nuevo Cliente: ");

            Console.Write("Razon Social: ");
            string razonSocial = Console.ReadLine();
            Console.Write("Rut: ");
            string rut = Console.ReadLine();
            Console.Write("Direccion: ");
            string direccion = Console.ReadLine();
            Console.Write("Telefono: ");
            string telefono = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(razonSocial, rut, direccion, telefono, email);

            clientes.Add(cliente);
        }
        private void MostrarCliente()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el rut del Cliente a mostrar:");
            string rut = Console.ReadLine();

            int index = ObtenerVehiculo(rut);

            clientes[index].ObtenerInfoCliente();


        }

        private void EliminarCliente()
        {
            Console.WriteLine("Ingrese el rut del Cliente para eliminarlo");
            string rut= Console.ReadLine();

            Cliente clienteAEliminar = clientes.Find(c => c.Rut == rut);

            if (clienteAEliminar != null)
            {
                // Elimina el cliente de la lista
                clientes.Remove(clienteAEliminar);
                Console.WriteLine("Cliente eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado. Verifique el RUT ingresado.");
            }
        }
        private void EditarCliente()
        {
            Console.WriteLine("Ingrese el RUT del Cliente que desea editar:");
            string rut = Console.ReadLine();

            // Busca el cliente por su RUT en la lista
            Cliente clienteAEditar = clientes.Find(c => c.Rut == rut);

            if (clienteAEditar != null)
            {
                Console.WriteLine("Cliente encontrado. Ingrese los nuevos datos:");

                Console.WriteLine("Nueva Razón Social:");
                clienteAEditar.RazonSocial = Console.ReadLine();

                Console.WriteLine("Nueva Dirección:");
                clienteAEditar.Direccion = Console.ReadLine();

                Console.WriteLine("Nuevo Teléfono de Contacto:");
                clienteAEditar.Telefono = Console.ReadLine();

                Console.WriteLine("Nuevo Email de Contacto:");
                clienteAEditar.Email = Console.ReadLine();

                Console.WriteLine("Cliente editado con éxito.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado. Verifique el RUT ingresado.");
            }
        }




    }

    }


    

