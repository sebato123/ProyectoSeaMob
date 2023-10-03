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
            string rutCliente = Console.ReadLine();
            Console.Write("Direccion: ");
            string direccion = Console.ReadLine();
            Console.Write("Telefono: ");
            string telefonoCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(razonSocial, rutCliente, direccion, telefonoCliente, email);

            clientes.Add(cliente);
        }

        private void MostrarCliente()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el rut del Cliente a mostrar:");
            string rutCliente = Console.ReadLine();

            int index = ObtenerCliente(rutCliente);
            clientes[index].ObtenerInfoCliente();

        }

        private int ObtenerCliente(string rutCliente)
        {
            foreach (Cliente cliente in clientes)
            {
                if (rutCliente == cliente.RutCliente)
                {
                    return clientes.IndexOf(cliente);
                }
            }
            return 0;
        }

        private void EliminarCliente()
        {
            Console.WriteLine("Ingrese el rut del Cliente para eliminarlo");
            string rutCliente = Console.ReadLine();

            Cliente clienteAEliminar = clientes.Find(cliente => cliente.RutCliente == rutCliente);

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
            string rutCliente = Console.ReadLine();

            // Busca el cliente por su RUT en la lista
            Cliente clienteAEditar = clientes.Find(cliente => cliente.RutCliente == rutCliente);

            if (clienteAEditar != null)
            {
                Console.WriteLine("Cliente encontrado. Ingrese los nuevos datos:");

                Console.WriteLine("Nueva Razón Social:");
                clienteAEditar.RazonSocial = Console.ReadLine();

                Console.WriteLine("Nuevo Rut: ");
                clienteAEditar.RutCliente = Console.ReadLine(); //Si falla puede ser esto

                Console.WriteLine("Nueva Dirección:");
                clienteAEditar.Direccion = Console.ReadLine();

                Console.WriteLine("Nuevo Teléfono de Contacto:");
                clienteAEditar.TelefonoCliente = Console.ReadLine();

                Console.WriteLine("Nuevo Email de Contacto:");
                clienteAEditar.Email = Console.ReadLine();

                Console.WriteLine("Cliente editado con éxito.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado. Verifique el RUT ingresado.");
            }
        }

        //---------------------Empleado-----------------------------------------------

        private void AgregarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Informacion del nuevo Empleado: ");
            Console.WriteLine();

            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Rut: ");
            string rutEmpleado = Console.ReadLine();

            Console.WriteLine("Telefono: ");
            string telefonoEmpleado = Console.ReadLine();
        }
        private void MostrarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el rut del Empleado a mostrar:");
            string rutEmpleado = Console.ReadLine();

            int index = ObtenerEmpleado(rutEmpleado);

            empleados[index].ObtenerInfoEmpleado();

        }
        private int ObtenerEmpleado(string rutEmpleado)
        {
            foreach (Empleado empleado in empleados)
            {
                if (rutEmpleado == empleado.RutEmpleado)
                {
                    return empleados.IndexOf(empleado);
                }
            }
            return 0;
        }
        private void EliminarEmpleado()
        {
            Console.WriteLine("Ingrese el rut del Empleado para eliminarlo");
            string rutEmpleado = Console.ReadLine();

            Empleado EmpleadoAEliminar = empleados.Find(empleado => empleado.RutEmpleado == rutEmpleado);

            if (EmpleadoAEliminar != null)
            {
                // Elimina el cliente de la lista
                empleados.Remove(EmpleadoAEliminar);
                Console.WriteLine("Cliente eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado. Verifique el RUT ingresado.");
            }
        }
        private void EditarEmpleado()
        {
            Console.WriteLine("Ingrese el RUT del Empleado que desea editar:");
            string rutEmpleado = Console.ReadLine();

            // Busca el Empleado por su RUT en la lista
            Empleado empleadoAEditar = empleados.Find(empleado => empleado.RutEmpleado == rutEmpleado);

            if (empleadoAEditar != null)
            {
                Console.WriteLine("Cliente encontrado. Ingrese los nuevos datos:");

                Console.WriteLine("Nueva Razón Social:");
                empleadoAEditar.Nombre = Console.ReadLine();

                Console.WriteLine("Nuevo Rut: ");
                empleadoAEditar.RutEmpleado = Console.ReadLine(); //Si falla puede ser esto


                Console.WriteLine("Nuevo Teléfono de Contacto:");
                empleadoAEditar.TelefonoEmpleado = Console.ReadLine();


                Console.WriteLine("Cliente editado con éxito.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado. Verifique el RUT ingresado.");
            }


        }

    }
}


    

