using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoPOO_1
{
    public class SistemaUsuario
    {
        private List<Empleado> empleados;
        private List<Cliente> clientes;
        private List<Vehiculo> vehiculos;
        private List<InfoReparacionMantencion> info;
        private List<Piezas> piezas;
        private List<Piezas> piezasMantencion;
        private Empleado nuevoEmpleado;



        public SistemaUsuario()
        {
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            vehiculos = new List<Vehiculo>();
            info = new List<InfoReparacionMantencion>();
            piezas = new List<Piezas>();
            piezasMantencion = new List<Piezas>();

        }

        public void Sistema()
        {
            bool salir = false;
            int opcion = 0;
            while (salir == false)
            {
                Console.Clear();
                Console.WriteLine("-------------------IDVRV-------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("");


                Console.WriteLine("Que desea Agregar, editar, eliminar o listar?: ");
                Console.WriteLine("");
                Console.WriteLine("1. Cliente");
                Console.WriteLine("2. Vehiculo");
                Console.WriteLine("3. Empleado");
                Console.WriteLine("4. Partes o Piezas");
                Console.WriteLine("5. Mantenciones");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Otras Opciones: ");
                Console.WriteLine("");
                Console.WriteLine("6. Listar todas las mantenciones que no se han completado");
                Console.WriteLine("");
                Console.WriteLine("7. Listar todos los vehículos con sus mantenciones realizadas y partes o piezas\r\nutilizadas, ordenados por fecha de ingreso.");
                Console.WriteLine("");
                Console.WriteLine("8. Listar todos los empleados, con sus mantenciones o reparaciones realizadas,\r\nordenadas por duración de la mantención");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("9. Guardar o Cargar info desde archivo");
                Console.WriteLine("");

                Console.WriteLine("10. Salir");


                bool volverAlMenu = false;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {

                    switch (opcion)
                    {
                        case 1://Cliente
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-------------------IDVRV-------------------");
                                Console.WriteLine("Que desea Hacer?");
                                Console.WriteLine("");
                                Console.WriteLine("1. Agregar Cliente");
                                Console.WriteLine("2. Editar Cliente");
                                Console.WriteLine("3. Eliminar Cliente");
                                Console.WriteLine("4. Listar Clientes");
                                Console.WriteLine();
                                Console.WriteLine("5. Volver al Menú Principal");

                                int opcionCliente;
                                if (int.TryParse(Console.ReadLine(), out opcionCliente))
                                {
                                    switch (opcionCliente)
                                    {
                                        case 1:
                                            AgregarCliente();
                                            break;
                                        case 2:
                                            EditarCliente();
                                            break;
                                        case 3:
                                            EliminarCliente();
                                            break;
                                        case 4:
                                            ListarCliente();
                                            break;
                                        case 5:
                                            volverAlMenu = true;
                                            break;

                                    }
                                }

                            } while (!volverAlMenu);

                            break;

                        case 2://Vehiculo
                            do
                            {


                                Console.Clear();
                                Console.WriteLine("-------------------IDVRV-------------------");
                                Console.WriteLine("Que desea Hacer?");
                                Console.WriteLine("");
                                Console.WriteLine("1. Agregar Vehiculo");
                                Console.WriteLine("2. Editar Vehiculo");
                                Console.WriteLine("3. Eliminar Vehiculo");
                                Console.WriteLine("4. Listar Vehiculos");
                                Console.WriteLine();
                                Console.WriteLine("5. Volver al Menú Principal");

                                int opcionVehiculo;
                                if (int.TryParse(Console.ReadLine(), out opcionVehiculo))
                                {

                                    switch (opcionVehiculo)
                                    {
                                        case 1:

                                            AgregarVehiculo();

                                            break;
                                        case 2:

                                            EditarVehiculo();

                                            break;
                                        case 3:

                                            EliminarVehiculo();

                                            break;

                                        case 4:

                                            ListarVehiculo();

                                            break;
                                        case 5:
                                            volverAlMenu = true;
                                            break;

                                    }
                                }
                            } while (!volverAlMenu);
                            break;
                        case 3:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-------------------IDVRV-------------------");
                                Console.WriteLine("Que desea Hacer?");
                                Console.WriteLine("");
                                Console.WriteLine("1. Agregar Empleado");
                                Console.WriteLine("2. Editar Empleado");
                                Console.WriteLine("3. Eliminar Empleado");
                                Console.WriteLine("4. Listar Empleado");
                                Console.WriteLine();
                                Console.WriteLine("5. Volver al Menú Principal");

                                int opcionEmpleado;
                                if (int.TryParse(Console.ReadLine(), out opcionEmpleado))
                                {

                                    switch (opcionEmpleado)
                                    {
                                        case 1:

                                            AgregarEmpleado();

                                            break;
                                        case 2:

                                            EditarEmpleado();

                                            break;
                                        case 3:

                                            EliminarEmpleado();

                                            break;

                                        case 4:

                                            ListarEmpleado();

                                            break;
                                        case 5:
                                            volverAlMenu = true;
                                            break;

                                    }
                                }
                            } while (!volverAlMenu);
                            break;
                        case 4://Partes o Piezas
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-------------------IDVRV-------------------");
                                Console.WriteLine("Que desea Hacer?");
                                Console.WriteLine("");
                                Console.WriteLine("1. Agregar Pieza");
                                Console.WriteLine("2. Editar Pieza");
                                Console.WriteLine("3. Eliminar Pieza");
                                Console.WriteLine("4. Listar Piezas");
                                Console.WriteLine();
                                Console.WriteLine("5. Volver al Menú Principal");

                                int opcionPiezas;
                                if (int.TryParse(Console.ReadLine(), out opcionPiezas))
                                {

                                    switch (opcionPiezas)
                                    {
                                        case 1:

                                            AgregarPiezas();

                                            break;
                                        case 2:

                                            EditarPiezas();

                                            break;
                                        case 3:

                                            EliminarPiezas();

                                            break;

                                        case 4:

                                            ListarPiezas();

                                            break;
                                        case 5:
                                            volverAlMenu = true;
                                            break;

                                    }
                                }
                            } while (!volverAlMenu);
                            break;
                        case 5://Mantenciones
                            do
                            {


                                Console.Clear();
                                Console.WriteLine("-------------------IDVRV-------------------");
                                Console.WriteLine("Que desea Hacer?");
                                Console.WriteLine("");
                                Console.WriteLine("1. Agregar Mantencion");
                                Console.WriteLine("2. Editar Mantencion");
                                Console.WriteLine("3. Eliminar Mantencion");
                                Console.WriteLine("4. Listar Mantenciones");
                                Console.WriteLine();
                                Console.WriteLine("5. Volver al Menú Principal");

                                int opcionMantenciones;
                                if (int.TryParse(Console.ReadLine(), out opcionMantenciones))
                                {

                                    switch (opcionMantenciones)
                                    {
                                        case 1:

                                            AgregarMantencion();

                                            break;
                                        case 2:

                                            EditarMantencion();

                                            break;
                                        case 3:

                                            EliminarMantencion();

                                            break;

                                        case 4:

                                            ListarMantencion();

                                            break;
                                        case 5:
                                            volverAlMenu = true;
                                            break;

                                    }
                                }
                            } while (!volverAlMenu);
                            break;


                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------IDVRV-------------------");
                            Console.WriteLine("");
                            Console.WriteLine("Mantenciones que no se han completado: ");
                            Console.WriteLine("");

                            MantencionesNoCompletadas();


                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------IDVRV-------------------");
                            Console.WriteLine("Mantenciones realizadas y partes o piezas utilizadas (Ordenadas por fecha de ingreso): ");
                            Console.WriteLine("");

                            TodasMantenciones();

                            break;

                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------IDVRV-------------------");
                            Console.WriteLine("Empleados, con sus mantenciones o reparaciones realizadas (Ordenadas por duracion de la mantencion): ");
                            Console.WriteLine("");

                            EmpleadosMantenciones();

                            break;

                        case 9:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-------------------IDVRV-------------------");
                                Console.WriteLine("Que desea Hacer?");
                                Console.WriteLine("");
                                Console.WriteLine("1. Guardar en archivo");
                                Console.WriteLine("2. Cargar en archivo");
                                Console.WriteLine();
                                Console.WriteLine("3. Volver al Menú Principal");

                                int opcionArchivos;
                                if (int.TryParse(Console.ReadLine(), out opcionArchivos))
                                {

                                    switch (opcionArchivos)
                                    {
                                        case 1:

                                            GuardarInfoEnArchivo();

                                            break;
                                        case 2:

                                            CargarInfoDesdeArchivo();

                                            break;
                                        case 3:

                                            volverAlMenu = true;

                                            break;


                                    }
                                }
                            } while (!volverAlMenu);
                            break;
                        case 10:

                            salir = true;

                            break;

                    }
                }
            }
        }
        //-------------------VEHICULOS-------------------------------
        /// <summary>
        /// Este método permite agregar un nuevo vehículo a una lista de vehículos, solicitando información al usuario.
        /// </summary>
        private void AgregarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Información del nuevo vehículo:");
            Cliente nuevoDueno = null;

            Console.WriteLine("Ingrese la patente del vehiculo: ");
            string patente = Console.ReadLine();

            // Verifica si el vehículo ya existe en la lista.
            if (ExisteVehiculo(patente))
            {
                Console.WriteLine("Ese vehículo ya existe");
            }
            else
            {
                Console.WriteLine("A continuación deberá ingresar al dueño del vehículo:");
                bool salir = false;

                while (!salir)
                {
                    Console.WriteLine("1.- Ingresar cliente nuevo\n2.- Ingresar cliente existente");
                    int opcion;

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                // Llama al método AgregarCliente() para agregar un nuevo cliente.
                                AgregarCliente();
                                nuevoDueno = clientes.Last();
                                salir = true;
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el rut del dueño del vehículo:");
                                string rut = Console.ReadLine();

                                // Busca al cliente existente por su rut.
                                int empleadoIndex = ObtenerEmpleado(rut);

                                if (empleadoIndex == -1)
                                {
                                    Console.WriteLine("Ese cliente no existe.");
                                }
                                else
                                {
                                    nuevoDueno = clientes[empleadoIndex];
                                    salir = true;
                                }
                                break;
                            default:
                                Console.WriteLine("Elija una opción válida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un número válido.");
                    }
                }
                Console.WriteLine("Se han ingresado los datos del dueño correctamente.");

                Console.WriteLine("Ingrese la marca:");
                string marca = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo:");
                string modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el color:");
                string color = Console.ReadLine();
                Console.WriteLine("Ingrese el año:");

                if (int.TryParse(Console.ReadLine(), out int ano))
                {
                    // Crea un nuevo objeto Vehiculo con la información proporcionada y lo agrega a la lista de vehículos.
                    Vehiculo vehiculo = new Vehiculo(marca, patente, modelo, color, ano, nuevoDueno);
                    vehiculos.Add(vehiculo);
                }
                else
                {
                    Console.WriteLine("Año no válido. El vehículo no se agregó.");
                }
                Console.WriteLine("El vehiculo se ha registrado exitosamente.");
                Console.ReadKey();
            }
        }


        /// <summary>
        /// Este método permite editar la información de un vehículo existente en la lista de vehículos.
        /// </summary>
        private void EditarVehiculo()
        {
            // Se limpia la consola y se pide el identificador respectivo
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehículo a modificar:");
            string patente = Console.ReadLine();

            // Se comprueba si existe el vehículo con la patente especificada
            int index = ObtenerVehiculo(patente);

            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado el vehículo.");
            }
            else
            {
                // Menú para elegir qué se desea modificar, se realiza a través de los métodos Set y Get respectivos.
                Console.WriteLine("Elija lo que quiere editar: \n 1.- Patente. \n 2.- Marca. \n 3.- Modelo. \n 4.- Color. \n 5.- Año. \n 6.- Salir");
                int opcion = int.Parse(Console.ReadLine());
                bool salir = false;

                while (salir == false)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Patente = Console.ReadLine();
                            Console.ReadKey();
                            salir = true;
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Marca = Console.ReadLine();
                            salir = true;
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Modelo = Console.ReadLine();
                            salir = true;
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Color = Console.ReadLine();
                            salir = true;
                            break;
                        case 5:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Ano = int.Parse(Console.ReadLine());
                            salir = true;
                            break;
                        case 6:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elija una opción válida.");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Este método permite eliminar un vehículo de la lista de vehículos y, al mismo tiempo, eliminar la información de mantenimiento asociada a ese vehículo.
        /// </summary>
        private void EliminarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehículo a eliminar, se eliminará la información de mantenimiento asociada:");
            string patente = Console.ReadLine();

            // Busca el vehículo en la lista por su patente.
            int index = ObtenerVehiculo(patente);

            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado el vehículo.");
            }
            else
            {
                // Elimina el vehículo de la lista de vehículos.
                vehiculos.RemoveAt(index);

                // Itera sobre la lista de información de mantenimiento y elimina las entradas asociadas a la patente.
                for (int i = info.Count - 1; i >= 0; i--)
                {
                    if (patente == info[i].Patente)
                    {
                        info.RemoveAt(i);
                    }
                }

                Console.WriteLine("El vehículo se ha eliminado correctamente junto con su información de mantenimiento asociada.");
            }
        }


        /// <summary>
        /// Este método lista todos los vehículos almacenados en la lista de vehículos, mostrando su información en la consola.
        /// </summary>
        private void ListarVehiculo()
        {
            int n = 1;
            Console.Clear();

            // Itera a través de la lista de vehículos y muestra la información de cada vehículo en la consola.
            foreach (Vehiculo auto in vehiculos)
            {
                Console.WriteLine("---------------- Vehículo " + n + " -----------------");
                auto.ObtenerInformacion();
                n++;
            }
        }


        /// <summary>
        /// Este método busca un vehículo en la lista de vehículos por su número de patente y devuelve el índice del vehículo si se encuentra.
        /// </summary>
        /// <param name="patente">La patente del vehículo que se desea buscar.</param>
        /// <returns>
        /// El índice del vehículo si se encuentra; de lo contrario, devuelve -1.
        /// </returns>
        private int ObtenerVehiculo(string patente)
        {
            foreach (Vehiculo auto in vehiculos)
            {
                if (patente == auto.Patente)
                {
                    return vehiculos.IndexOf(auto);
                }
            }
            Console.WriteLine("No se pudo encontrar el vehículo");
            return -1;
        }

        /// <summary>
        /// Este método verifica si un vehículo con una patente específica existe en la lista de vehículos.
        /// </summary>
        /// <param name="patente">La patente del vehículo que se desea verificar.</param>
        /// <returns>
        /// Verdadero (true) si el vehículo con la patente especificada existe en la lista; de lo contrario, falso (false).
        /// </returns>
        private bool ExisteVehiculo(string patente)
        {
            foreach (Vehiculo auto in vehiculos)
            {
                if (patente == auto.Patente)
                {
                    return true;
                }
            }
            return false;
        }



        //------------------------------------------------------------
        //------------------------PARTES  Y PIEZAS ------------------------

        /// <summary>
        /// Este método permite agregar una nueva pieza o parte a una lista de piezas, solicitando información al usuario.
        /// </summary>
        private void AgregarPiezas()
        {
            Console.Clear();
            Console.WriteLine("Información de la nueva Pieza/Parte");

            Console.WriteLine("Ingrese el identificador único de la pieza:");
            string identificadorUnico = Console.ReadLine();

            // Verifica si la pieza ya existe en la lista.
            if (ExistePieza(identificadorUnico) == true)
            {
                Console.WriteLine("Esa pieza ya existe");
            }
            else
            {
                Console.WriteLine("Ingrese la marca de la pieza:");
                string marcaPieza = Console.ReadLine();
                Console.WriteLine("Ingrese el proveedor de la pieza:");
                string proveedor = Console.ReadLine();
                Console.WriteLine("Ingrese el costo unitario de la pieza:");
                string costoUnitario = Console.ReadLine();

                // Crea un nuevo objeto Piezas con la información proporcionada y lo agrega a la lista de piezas.
                Piezas pieza = new Piezas(identificadorUnico, marcaPieza, proveedor, costoUnitario);
                piezas.Add(pieza);
            }
        }

        /// <summary>
        /// Este método permite editar la información de una pieza o parte existente en una lista de piezas, solicitando al usuario la información a modificar.
        /// </summary>
        private void EditarPiezas()
        {
            // Se limpia la consola y se pide el identificador respectivo
            Console.Clear();
            Console.WriteLine("Ingrese el identificador único de la pieza a modificar:");
            string id = Console.ReadLine();

            // Se comprueba si existe la pieza con el identificador único especificado
            int index = ObtenerPiezas(id);

            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado la pieza.");
            }
            else
            {
                // Menú para elegir qué se desea modificar, se realiza a través de los métodos Set y Get respectivos.
                Console.WriteLine("Elija lo que quiere editar: \n 1.- Identificador Único. \n 2.- Marca. \n 3.- Proveedor. \n 4.- Costo Unitario. \n 5.- Salir");
                int opcion = int.Parse(Console.ReadLine());
                bool salir = false;

                while (salir == false)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            piezas[index].IdentificadorUnico = Console.ReadLine();
                            Console.ReadKey();
                            salir = true;
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            piezas[index].Marca = Console.ReadLine();
                            salir = true;
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            piezas[index].Proveedor = Console.ReadLine();
                            salir = true;
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            piezas[index].CostoUnitario = Console.ReadLine();
                            salir = true;
                            break;
                        case 5:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elija una opción válida.");
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// Este método permite eliminar una pieza o parte de una lista de piezas, así como eliminar las referencias de la pieza en la información de mantenimiento asociada.
        /// </summary>
        private void EliminarPiezas()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el identificador único de la pieza/parte a eliminar, se eliminarán de la información de mantenimiento asociada:");
            string id = Console.ReadLine();

            // Se comprueba si existe la pieza con el identificador único especificado
            int index = ObtenerPiezas(id);

            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado la pieza.");
            }
            else
            {
                // Elimina la pieza de la lista de piezas.
                piezas.RemoveAt(index);

                // Itera sobre la lista de información de mantenimiento y elimina las referencias de la pieza en la lista de piezas de cada entrada.
                foreach (InfoReparacionMantencion a in info)
                {
                    foreach (Piezas b in a.ListaPiezas)
                    {
                        if (id == b.IdentificadorUnico)
                        {
                            a.ListaPiezas.Remove(b);
                            break; // Se rompe el bucle después de eliminar la pieza para evitar problemas de modificación.
                        }
                    }
                }

                Console.WriteLine("La pieza se ha eliminado correctamente");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Este método lista todas las piezas o partes almacenadas en la lista de piezas, mostrando su información en la consola.
        /// </summary>
        private void ListarPiezas()
        {
            int n = 1;
            Console.Clear();

            // Itera a través de la lista de piezas y muestra la información de cada pieza en la consola.
            foreach (Piezas pieza in piezas)
            {
                Console.WriteLine("---------------- Pieza " + n + " -----------------");
                pieza.ObtenerInformacion();
                n++;
            }
        }


        /// <summary>
        /// Este método busca una pieza o parte en la lista de piezas por su identificador único y devuelve el índice de la pieza si se encuentra.
        /// </summary>
        /// <param name="id">El identificador único de la pieza que se desea buscar.</param>
        /// <returns>
        /// El índice de la pieza si se encuentra; de lo contrario, devuelve -1.
        /// </returns>
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
            return -1;
        }

        /// <summary>
        /// Este método verifica si una pieza o parte con un identificador único específico existe en la lista de piezas.
        /// </summary>
        /// <param name="id">El identificador único de la pieza que se desea verificar.</param>
        /// <returns>
        /// Verdadero (true) si la pieza con el identificador único especificado existe en la lista; de lo contrario, falso (false).
        /// </returns>
        private bool ExistePieza(string id)
        {
            foreach (Piezas pieza in piezas)
            {
                if (id == pieza.IdentificadorUnico)
                {
                    return true;
                }
            }
            return false;
        }

        //----------------------------------------------------------------------------------

        //----------------------------------MANTENCIONES-------------------------

        /// <summary>
        /// Este método permite agregar información de una nueva mantención, solicitando la información necesaria al usuario.
        /// </summary>
        private void AgregarMantencion()
        {
            try
            {
                piezasMantencion.Clear();
                Console.Clear();
                Console.WriteLine("A continuación, ingrese la información correspondiente a la mantención:");
                string patente = "";

                while (true)
                {
                    int opcion;
                    bool salir = false;
                    while (salir == false)
                    {
                        Console.WriteLine("1.- Ingresar vehiculo nuevo. \n2.- Ingresar vehiculo existente.");
                        opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                AgregarVehiculo();
                                patente = vehiculos.Last().Patente;
                                salir = true; break;
                            case 2:
                                Console.WriteLine("Ingrese la patente del vehiculo.");
                                patente = Console.ReadLine();

                                if (ExisteMantencion(patente))
                                {
                                    Console.WriteLine("Este vehiculo ya tiene una mantencion registrada."); break;

                                }
                                if (ObtenerVehiculo(patente) < 0)
                                {
                                    Console.WriteLine("No se ha encontrado el vehiculo."); break;
                                }
                                salir = true; break;
                            default:
                                Console.WriteLine("Ingrese una opcion valida.");
                                break;
                        }
                        Console.WriteLine("El vehiculo ha sido registrado en la mantencion correctamente.");
                    }
                    // Se pide el empleado a cargo.
                    Console.WriteLine("Ingrese el empleado a cargo de la mantención:");
                    bool salirMantencion = false;
                    while (salirMantencion == false)
                    {
                        // Mini menú para ingresar un empleado nuevo o ya existente.
                        Console.WriteLine("1.- Ingresar empleado existente. \n 2.- Ingresar empleado nuevo");
                        int.TryParse(Console.ReadLine(), out opcion);
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el rut del empleado");
                                string rut = Console.ReadLine();
                                int index = ObtenerEmpleado(rut);
                                if (index < 0)
                                {
                                    Console.WriteLine("No se encontró el empleado.");
                                    break;
                                }
                                nuevoEmpleado = empleados[index];
                                salirMantencion = true;
                                break;
                            case 2:
                                AgregarEmpleado();
                                nuevoEmpleado = empleados.Last();
                                salirMantencion = true;
                                break;
                            default:
                                Console.WriteLine("Elija una opción válida.");
                                break;
                        }
                        Console.Clear();
                    }
                    Console.WriteLine("Ingrese el kilometraje");
                    string kilometraje = Console.ReadLine();

                    Console.WriteLine("Ingrese la descripción de la inspección visual");
                    string inspeccion = Console.ReadLine();

                    Console.WriteLine("Ingrese el trabajo a realizar:");
                    string trabajo = Console.ReadLine();

                    // Ingresar fecha de ingreso en formato año mes día.
                    string fechaIngreso;
                    while (true)
                    {
                        Console.WriteLine("Ingrese la fecha de ingreso del vehículo en formato AAAA-MM-DD:");
                        fechaIngreso = Console.ReadLine();

                        if (DateTime.TryParseExact(fechaIngreso, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                        {
                            Console.WriteLine("Fecha ingresada válida: " + fecha.ToString("yyyy-MM-dd"));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fecha ingresada no válida.");
                        }
                    }

                    // While para crear un menú donde agregar las piezas a utilizar.
                    salirMantencion = false;
                    while (salirMantencion == false)
                    {
                        Console.WriteLine("A continuación deberá ingresar las partes/piezas que serán utilizadas en la mantención");
                        Console.WriteLine("1.- Ingresar pieza nueva. \n 2.- Ingresar pieza existente. \n 3.- Terminar de elegir piezas");
                        opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                AgregarPiezas();
                                Piezas ultimaPieza = piezas.Last();
                                piezasMantencion.Add(ultimaPieza);
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el identificador único de la pieza:");
                                string id = Console.ReadLine();
                                int index = ObtenerPiezas(id);
                                if (index < 0)
                                {
                                    Console.WriteLine("No se encontró la pieza.");
                                    break;
                                }
                                Piezas pieza1 = piezas[index];
                                piezasMantencion.Add(pieza1);
                                break;
                            case 3:
                                salirMantencion = true;
                                break;
                            default:
                                Console.WriteLine("Elija una opción válida");
                                break;
                        }
                    }
                    string nuevoFechaEntrega = ""; // Inicializado a una cadena vacía por defecto
                    bool nuevoEntrega = false;     // Inicializado como "no entregado" por defecto

                    while (true)
                    {
                        Console.WriteLine("¿El vehículo fue entregado? \n 1.- Entregado. \n 2.- No entregado.");

                        int opcionEntrega = int.Parse(Console.ReadLine());

                        if (opcionEntrega == 1)
                        {
                            nuevoEntrega = true;

                            while (true)
                            {
                                Console.WriteLine("Ingrese la fecha de entrega del vehiculo en formato AAAA-MM-DD, recuerda que la fecha de entrega no puede ser menor a la de ingreso:");
                                string fechaEntregaInput = Console.ReadLine();

                                if (DateTime.TryParseExact(fechaEntregaInput, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaEntregaValue) && (DateTime.Parse(fechaIngreso) <= fechaEntregaValue))
                                {
                                    nuevoFechaEntrega = fechaEntregaInput; // Asignar el valor a la variable de instancia
                                    Console.WriteLine("Fecha ingresada válida: " + fechaEntregaValue.ToString("yyyy-MM-dd"));
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Fecha ingresada no válida.");
                                }
                            }
                        }
                        else if (opcionEntrega == 2)
                        {
                            nuevoEntrega = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Elija una opción válida.");
                        }
                    }

                    // Se agrega la información de la mantención.
                    InfoReparacionMantencion Mantencion = new InfoReparacionMantencion(patente, kilometraje, inspeccion, trabajo, fechaIngreso, piezasMantencion, nuevoEntrega, nuevoEmpleado, nuevoFechaEntrega);
                    info.Add(Mantencion);
                    Console.WriteLine("La mantencion se ha registrado exitosamente.");

                    // Se limpia la lista de piezas de mantención para reutilizarla.
                    piezasMantencion.Clear(); break;
                }
            }

            catch
            {
                Console.WriteLine("Al ingresar un dato en opcion, asegurese de que es un entero.");
                Console.WriteLine("Los clientes, vehiculos, piezas y empleados que hayas creado se guardaron. ");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Este método permite editar la información de una mantención existente, solicitando la identificación y ofreciendo opciones para editar sus atributos.
        /// </summary>
        private void EditarMantencion()
        {
            try
            {
                // Se limpia la consola y se pide el identificador respectivo
                Console.Clear();
                Console.WriteLine("Ingrese la patente de la mantención a modificar:");
                string id = Console.ReadLine();

                // Se comprueba si existe el identificador
                int index = ObtenerMantencion(id);

                if (index < 0)
                {
                    Console.WriteLine("No se ha encontrado la mantención.");
                }
                else
                {
                    // Menú para elegir qué se desea modificar, se modifica con los SetGet respectivos.
                    Console.WriteLine("Elija lo que quiere editar: \n 1.- Patente. \n 2.- Kilometraje. \n 3.- Inspección Visual. \n 4.- Trabajo. \n 5.- Fecha Ingreso");
                    Console.WriteLine("6.- Lista de Piezas. \n 7.- Fecha de Entrega. \n 8.- Empleado a cargo. \n 9.- Salir");

                    string auxiliar;
                    int opcion = int.Parse(Console.ReadLine());
                    bool salir = false;

                    while (salir == false)
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el nuevo dato:");
                                info[index].Patente = Console.ReadLine();
                                Console.ReadKey();
                                salir = true; break;
                            case 2:
                                Console.WriteLine("Ingrese el nuevo dato:");
                                info[index].Kilometraje = Console.ReadLine();
                                salir = true; break;
                            case 3:
                                Console.WriteLine("Ingrese el nuevo dato:");
                                info[index].Inspeccion = Console.ReadLine();
                                salir = true; break;
                            case 4:
                                Console.WriteLine("Ingrese el nuevo dato:");
                                info[index].Trabajo = Console.ReadLine();
                                salir = true; break;
                            case 5:
                                while (true)
                                {
                                    Console.WriteLine("Ingrese la fecha de ingreso del vehículo en formato AAAA-MM-DD:");
                                    auxiliar = Console.ReadLine();

                                    if (DateTime.TryParseExact(auxiliar, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                                    {
                                        Console.WriteLine("Fecha ingresada válida: " + fecha.ToString("yyyy-MM-dd"));
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fecha ingresada no válida.");
                                    }
                                }
                                info[index].FechaIngreso = auxiliar;
                                salir = true; break;
                            case 6:
                                while (salir == false)
                                {
                                    string idAuxiliar;
                                    int indexAuxiliar;
                                    Console.WriteLine("A continuación podrá editar las partes/piezas que serán utilizadas en la mantención");
                                    Console.WriteLine("1.- Ingresar pieza nueva. \n 2.- Ingresar pieza existente. \n 3.- Eliminar piezas.\n 4.- Editar piezas. \n 5.- Salir");
                                    opcion = int.Parse(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            AgregarPiezas();
                                            Piezas ultimaPieza = piezas.Last();
                                            piezasMantencion.Add(ultimaPieza);
                                            salir = true; break;
                                        case 2:
                                            Console.WriteLine("Ingrese el identificador único de la pieza:");
                                            idAuxiliar = Console.ReadLine();
                                            indexAuxiliar = ObtenerPiezas(idAuxiliar);
                                            if (indexAuxiliar < 0)
                                            {
                                                Console.WriteLine("No se encontró la pieza.");
                                                break;
                                            }
                                            Piezas pieza1 = piezas[indexAuxiliar];
                                            piezasMantencion.Add(pieza1);
                                            salir = true; break;
                                        case 3:
                                            Console.WriteLine("Ingrese el identificador único de la pieza:");
                                            idAuxiliar = Console.ReadLine();
                                            indexAuxiliar = ObtenerPiezas(idAuxiliar);
                                            if (indexAuxiliar < 0)
                                            {
                                                Console.WriteLine("No se encontró la pieza.");
                                                break;
                                            }
                                            piezasMantencion.RemoveAt(indexAuxiliar);
                                            salir = true; break;
                                        case 4:
                                            // Se limpia la consola y se pide el identificador respectivo
                                            Console.Clear();
                                            Console.WriteLine("Ingrese el identificador único de la pieza a modificar:");
                                            idAuxiliar = Console.ReadLine();
                                            indexAuxiliar = ObtenerPiezas(idAuxiliar);
                                            if (indexAuxiliar < 0)
                                            {
                                                Console.WriteLine("No se ha encontrado la pieza.");
                                            }
                                            else
                                            {
                                                // Menú para elegir qué se desea modificar, se modifica con los SetGet respectivos.
                                                Console.WriteLine("Elija lo que quiere editar: \n 1.- Identificador Único. \n 2.- Marca. \n 3.- Proveedor. \n 4.- Costo Unitario. \n 5.- Salir");
                                                opcion = int.Parse(Console.ReadLine());
                                                salir = false;

                                                while (salir == false)
                                                {
                                                    switch (opcion)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("Ingrese el nuevo dato:");
                                                            piezasMantencion[indexAuxiliar].IdentificadorUnico = Console.ReadLine();
                                                            Console.ReadKey();
                                                            salir = true; break;
                                                        case 2:
                                                            Console.WriteLine("Ingrese el nuevo dato:");
                                                            piezasMantencion[indexAuxiliar].Marca = Console.ReadLine();
                                                            salir = true; break;
                                                        case 3:
                                                            Console.WriteLine("Ingrese el nuevo dato:");
                                                            piezasMantencion[indexAuxiliar].Proveedor = Console.ReadLine();
                                                            salir = true; break;
                                                        case 4:
                                                            Console.WriteLine("Ingrese el nuevo dato:");
                                                            piezasMantencion[indexAuxiliar].CostoUnitario = Console.ReadLine();
                                                            salir = true; break;
                                                        case 5:
                                                            salir = true; break;
                                                        default:
                                                            Console.WriteLine("Elija una opción válida."); break;
                                                    }
                                                }
                                            }
                                            break;
                                        case 5:
                                            salir = true; break;
                                        default:
                                            Console.WriteLine("Elija una opción válida");
                                            break;
                                    }
                                }
                                break;
                            case 7:
                                if (!info[index].Entregado)
                                {
                                    Console.WriteLine("Este vehículo no ha sido entregado. ¿Desea establecerlo como entregado? Si/No");
                                    string entrega = Console.ReadLine();
                                    if (entrega == "Si" || entrega == "si")
                                    {
                                        info[index].Entregado = true;

                                        while (true)
                                        {
                                            Console.WriteLine("Ingrese la fecha de entrega del vehículo en formato AAAA-MM-DD:");
                                            auxiliar = Console.ReadLine();

                                            if (DateTime.TryParseExact(auxiliar, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                                            {
                                                Console.WriteLine("Fecha ingresada válida: " + fecha.ToString("yyyy-MM-dd"));
                                                info[index].FechaEntrega = auxiliar;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Fecha ingresada no válida.");
                                            }
                                        }
                                    }
                                    else if (entrega == "No" || entrega == "no")
                                    {
                                        salir = true; break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El vehículo fue entregado el: " + info[index].FechaEntrega);
                                    Console.WriteLine("1.- Modificar fecha entrega. 2.- Cancelar entrega. 3.- Salir");
                                    opcion = int.Parse(Console.ReadLine());
                                    salir = false;

                                    while (salir == false)
                                    {
                                        switch (opcion)
                                        {
                                            case 1:
                                                while (true)
                                                {
                                                    Console.WriteLine("Ingrese la fecha de entrega del vehículo en formato AAAA-MM-DD:");
                                                    auxiliar = Console.ReadLine();

                                                    if (DateTime.TryParseExact(auxiliar, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                                                    {
                                                        Console.WriteLine("Fecha ingresada válida: " + fecha.ToString("yyyy-MM-dd"));
                                                        info[index].FechaEntrega = auxiliar;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Fecha ingresada no válida.");
                                                    }
                                                }
                                                salir = true; break;
                                            case 2:
                                                info[index].Entregado = false;
                                                info[index].FechaEntrega = null;
                                                Console.WriteLine("La entrega ha sido cancelada.");
                                                salir = true; break;
                                            case 3:
                                                salir = true; break;
                                            default:
                                                Console.WriteLine("Elija una opción válida."); break;
                                        }
                                    }
                                }
                                break;
                            case 8:
                                Console.WriteLine("El empleado a cargo es: " + info[index].Empleado.Nombre);
                                salir = false;

                                while (salir == false)
                                {
                                    Console.WriteLine("1.- Cambiar el empleado a cargo. \n 2.- Modificar el empleado a cargo.\n 3.- Salir");
                                    opcion = int.Parse(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            Console.WriteLine("1.- Cambiar a empleado existente. \n 2.- Cambiar a empleado nuevo.\n 3.- Salir.");
                                            opcion = int.Parse(Console.ReadLine());

                                            switch (opcion)
                                            {
                                                case 1:
                                                    Console.WriteLine("Ingrese el rut del empleado");
                                                    string rut = Console.ReadLine();
                                                    int indexAuxiliar = ObtenerEmpleado(rut);

                                                    if (index < 0)
                                                    {
                                                        Console.WriteLine("No se encontró el empleado.");
                                                        break;
                                                    }

                                                    info[index].Empleado = empleados[indexAuxiliar];
                                                    salir = true;
                                                    break;
                                                case 2:
                                                    AgregarEmpleado();
                                                    info[index].Empleado = empleados.Last();
                                                    salir = true;
                                                    break;
                                                case 3:
                                                    salir = true; break;
                                                default:
                                                    Console.WriteLine("Elija una opción válida.");
                                                    break;
                                            }

                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.Clear();
                                            info[index].Empleado.ObtenerInfoEmpleado();
                                            // Menú para elegir qué se desea modificar, se modifica con los SetGet respectivos.
                                            Console.WriteLine("Elija lo que quiere editar: \n 1.- Rut. \n 2.- Razon Social. \n 3.- Telefono. \n 4.- Salir");
                                            opcion = int.Parse(Console.ReadLine());
                                            salir = false;

                                            while (salir == false)
                                            {
                                                switch (opcion)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Ingrese el nuevo dato:");
                                                        info[index].Empleado.RutEmpleado = Console.ReadLine();
                                                        Console.ReadKey();
                                                        salir = true; break;
                                                    case 2:
                                                        Console.WriteLine("Ingrese el nuevo dato:");
                                                        info[index].Empleado.Nombre = Console.ReadLine();
                                                        salir = true; break;
                                                    case 3:
                                                        Console.WriteLine("Ingrese el nuevo dato:");
                                                        info[index].Empleado.TelefonoEmpleado = Console.ReadLine();
                                                        salir = true; break;
                                                    case 4:
                                                        salir = true; break;
                                                    default:
                                                        Console.WriteLine("Elija una opción válida."); break;
                                                }
                                            }
                                            break;
                                        case 3:
                                            salir = true; break;
                                        default:
                                            Console.WriteLine("Elija una opción válida."); break;
                                    }
                                }
                                break;
                            case 9:
                                salir = true; break;
                            default:
                                Console.WriteLine("Elija una opción válida."); break;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ha ingresado un dato invalido, ingrese un numero entero.");
            }
            Console.ReadKey();
        }


        /// <summary>
        /// Elimina una mantención de la lista de mantenciones (info) basándose en la patente ingresada por el usuario.
        /// </summary>
        /// <remarks>
        /// El método solicita al usuario que ingrese la patente de la mantención que desea eliminar.
        /// Luego, verifica si existe una mantención con la patente proporcionada en la lista de mantenciones (info).
        /// Si se encuentra la mantención, se elimina de la lista.
        /// Si no se encuentra la mantención, se muestra un mensaje de error.
        /// </remarks>
        private void EliminarMantencion()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la patente de la mantencion que desea eliminar:");
            string patente = Console.ReadLine();
            int index = ObtenerMantencion(patente);
            if (index < 0)
            {
                Console.WriteLine("No se encontró la mantención.");
            }
            else
            {
                info.RemoveAt(index);
                Console.WriteLine("Se ha eliminado la mantención exitosamente.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Obtiene el índice de una mantención en la lista de mantenciones (info) según la patente proporcionada.
        /// </summary>
        /// <param name="patente">La patente del vehículo asociada a la mantención que se busca.</param>
        /// <returns>
        /// El índice de la mantención en la lista de mantenciones (info) si se encuentra; de lo contrario, devuelve -1.
        /// </returns>
        /// <remarks>
        /// El método recorre la lista de mantenciones (info) y compara la patente proporcionada con la patente de cada mantención.
        /// Si encuentra una mantención con la patente especificada, devuelve el índice de esa mantención en la lista.
        /// Si no se encuentra ninguna mantención con la patente proporcionada, devuelve -1.
        /// </remarks>
        private int ObtenerMantencion(string patente)
        {
            foreach (InfoReparacionMantencion repairs in info)
            {
                if (patente == repairs.Patente)
                {
                    return info.IndexOf(repairs);
                }
            }
            return -1;
        }

        /// <summary>
        /// Verifica si existe una mantención en la lista de mantenciones (info) basándose en la patente proporcionada.
        /// </summary>
        /// <param name="patente">La patente del vehículo asociada a la mantención que se busca.</param>
        /// <returns>
        /// Verdadero (true) si existe una mantención con la patente especificada en la lista; de lo contrario, falso (false).
        /// </returns>
        /// <remarks>
        /// El método recorre la lista de mantenciones (info) y compara la patente proporcionada con la patente de cada mantención.
        /// Si encuentra una mantención con la patente especificada, devuelve verdadero (true) para indicar que existe una mantención con esa patente.
        /// Si no se encuentra ninguna mantención con la patente proporcionada, devuelve falso (false).
        /// </remarks>
        private bool ExisteMantencion(string patente)
        {
            foreach (InfoReparacionMantencion A in info)
            {
                if (A.Patente == patente)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Muestra en la consola la información de todas las mantenciones almacenadas en la lista de mantenciones (info).
        /// </summary>
        /// <remarks>
        /// Este método recorre la lista de mantenciones (info) y muestra en la consola la información de cada mantención.
        /// Cada mantención se presenta con un encabezado numerado para facilitar la identificación.
        /// </remarks>
        private void ListarMantencion()
        {
            int n = 1;
            Console.Clear();
            foreach (InfoReparacionMantencion x in info)
            {
                Console.WriteLine("---------------- Mantencion " + n + " -----------------");
                x.ObtenerInformacion();
                n++;
            }
            Console.ReadKey();
        }


        //-------------------------------------------------------------------------------


        //---------------FUNCIONES EXTRAS--------------------------

        /// <summary>
        /// Muestra en la consola la información de las mantenciones que no han sido completadas.
        /// </summary>
        /// <remarks>
        /// Este método recorre la lista de mantenciones (info) y verifica el estado de entrega de cada mantención.
        /// Muestra en la consola la información de las mantenciones que no han sido entregadas (Entregado = false).
        /// También informa si todas las mantenciones registradas han sido entregadas.
        /// </remarks>
        private void MantencionesNoCompletadas()
        {
            int i = 0;
            int j = 0;

            // Si no hay mantenciones
            if (info.Count <= 0)
            {
                Console.WriteLine("No hay mantenciones registradas.");
            }
            else
            {
                foreach (InfoReparacionMantencion M in info)
                {
                    i++;
                    // Se revisa si el bool Entregado está en false, si el vehículo no ha sido entregado, se imprime la información en pantalla
                    if (M.Entregado == false)
                    {
                        Console.WriteLine("---------------- Vehiculo " + i + "------------------");
                        M.ObtenerInformacion();
                    }
                    else
                    {
                        j++;
                    } // Se suma j si el vehículo fue entregado.
                }
                // Si j es igual a la cantidad de elementos en info, eso significa que todos los vehículos fueron entregados.
                if (j == info.Count)
                {
                    Console.WriteLine("Todos los vehículos registrados fueron entregados");
                }
            }
            Console.ReadKey();
        }


        /// <summary>
        /// Muestra en la consola la información de todas las mantenciones registradas, ordenadas por fecha de ingreso.
        /// </summary>
        /// <remarks>
        /// Este método lista y muestra en la consola la información de todos los vehículos con sus respectivas mantenciones y piezas utilizadas.
        /// Los vehículos se ordenan por su fecha de ingreso.
        /// Si no hay mantenciones registradas, muestra un mensaje indicando que no hay mantenciones.
        /// </remarks>
        private void TodasMantenciones()
        {
            Console.Clear();

            if (info.Count == 0)
            {
                Console.WriteLine("No hay mantenciones registradas.");
            }
            else
            {
                Console.WriteLine("A continuación se listarán todos los vehículos con sus mantenciones realizadas y partes o piezas utilizadas, ordenados por fecha de ingreso.");

                // Se crea una lista donde se guardarán el orden de las fechas de ingreso.
                List<string> ordenIngreso = new List<string>();

                foreach (InfoReparacionMantencion x in info)
                {
                    // Se almacenan todas las fechas de ingreso en la lista ordenIngreso.
                    ordenIngreso.Add(x.FechaIngreso);
                }

                // Se ordenan las fechas con OrderBy y se almacenan en la lista fechasOrdenadas.
                var fechasOrdenadas = ordenIngreso.OrderBy(fecha => fecha).ToList();

                // Variables para usar en el bucle.
                int i = 0;
                int j = 0;

                while (true)
                {
                    foreach (InfoReparacionMantencion y in info)
                    {
                        // Se comprueba si la fecha de ingreso de y es igual al índice i de ordenIngreso.
                        if (y.FechaIngreso == ordenIngreso[i])
                        {
                            // Se imprime la información del vehículo y se incrementa i.
                            Console.WriteLine("----------- Vehiculo " + (i + 1) + "-------------");
                            y.ObtenerInformacion();
                            i++;
                        }
                    }
                    j++;

                    // Se verifica si j es mayor o igual a la cantidad de elementos de ordenIngreso.
                    // Si es igual, se rompe el ciclo.
                    if (j >= ordenIngreso.Count - 1)
                    {
                        break;
                    }
                }
            }

            Console.ReadKey();
        }



        /// <summary>
        /// Lista y muestra en la consola a todos los empleados con sus mantenciones o reparaciones realizadas, ordenadas por duración de la mantención.
        /// </summary>
        /// <remarks>
        /// Este método muestra en la consola a todos los empleados registrados con sus respectivas mantenciones o reparaciones realizadas.
        /// Las mantenciones se ordenan por su duración, de menor a mayor. Si no hay empleados registrados, muestra un mensaje indicando que no hay empleados.
        /// </remarks>
        private void EmpleadosMantenciones()
        {
            Console.Clear();

            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
            }
            else
            {
                Console.WriteLine("A continuación se listarán todos los empleados, con sus mantenciones o reparaciones realizadas, ordenadas por duración de la mantención.");

                foreach (Empleado x in empleados)
                {
                    // Se crean dos listas que se usarán para ordenar los datos.
                    List<InfoReparacionMantencion> mantenciones = new List<InfoReparacionMantencion>();
                    List<InfoReparacionMantencion> mantencionesOrdenadas = new List<InfoReparacionMantencion>();
                    List<int> orden = new List<int>();

                    // Se agregan las mantenciones que corresponden al empleado a la lista mantenciones.
                    foreach (InfoReparacionMantencion y in info)
                    {
                        if (y.Empleado == x)
                        {
                            mantenciones.Add(y);
                        }
                    }

                    // Se revisa si el vehículo fue entregado; de ser así, se llama a DiferenciaFechas y se agrega a la lista orden.
                    foreach (InfoReparacionMantencion w in mantenciones)
                    {
                        if (w.Entregado == true)
                        {
                            orden.Add(w.DiferenciaFechas());
                            mantencionesOrdenadas.Add(w);
                        }
                    }

                    // Se ordenan las diferencias de días de menor a mayor.
                    orden.OrderBy(diferencia => diferencia).ToList();

                    // Se imprime el nombre del empleado, se crean las variables i y j y se inician en 0.
                    Console.Write("---- " + x.Nombre + " ----\n");
                    int i = 0;
                    int j = 0;

                    while (true)
                    {
                        // Se vuelve a poner i en 0.
                        if (j >= orden.Count) // Si j es mayor al Count de orden, significa que ya se revisaron todos los elementos de orden.
                        {
                            break;
                        }

                        foreach (InfoReparacionMantencion z in mantencionesOrdenadas)
                        {
                            // Se revisa si el elemento i de orden es igual a la diferencia de cualquier mantención.
                            if (z.DiferenciaFechas() == orden[i])
                            {
                                Console.WriteLine("----------- Mantencion " + (i + 1) + "-------------");
                                z.ObtenerInformacion();
                                Console.WriteLine("La mantención ha durado: " + z.DiferenciaFechas() + " días.");
                                i++;
                            }
                        }
                        j++;
                        mantenciones.Clear();
                    }
                }
            }

            Console.ReadKey();
        }
        //-----------------------------CLIENTE----------------------
        /// <summary>
        /// Agrega un nuevo cliente a la lista de clientes.
        /// </summary>
        /// <remarks>
        /// Este método solicita al usuario ingresar información sobre un nuevo cliente, incluyendo su Rut, Razón Social, Dirección, Teléfono y Email.
        /// Luego, crea una instancia de la clase Cliente con la información proporcionada y la agrega a la lista de clientes.
        /// </remarks>
        private void AgregarCliente()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            Console.WriteLine("Información del nuevo Cliente: ");
            Console.WriteLine("");

            Console.Write("Rut: ");
            string rutCliente = Console.ReadLine();
            Console.Write("Razón Social: ");
            string razonSocial = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Teléfono: ");
            string telefonoCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(razonSocial, rutCliente, direccion, telefonoCliente, email);

            clientes.Add(cliente);
        }
        /// <summary>
        /// Muestra en la consola la información de todos los clientes registrados.
        /// </summary>
        /// <remarks>
        /// Este método recorre la lista de clientes y muestra la información de cada cliente en la consola, incluyendo su Rut, Razón Social, Dirección, Teléfono y Email.
        /// La información se muestra numerada para identificar cada cliente en la lista.
        /// </remarks>
        private void ListarCliente()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            int n = 1;
            Console.Clear();

            // Itera a través de la lista de clientes y muestra la información de cada cliente en la consola.
            foreach (Cliente a in clientes)
            {
                Console.WriteLine("---------------- Cliente " + n + " -----------------");
                a.ObtenerInfoCliente();
                n++;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Busca un cliente en la lista de clientes por su número de Rut.
        /// </summary>
        /// <param name="rutCliente">El Rut del cliente que se desea buscar.</param>
        /// <returns>El índice del cliente en la lista de clientes si se encuentra; de lo contrario, devuelve -1.</returns>
        /// <remarks>
        /// Este método busca un cliente en la lista de clientes comparando el Rut proporcionado con el Rut de cada cliente en la lista.
        /// Si se encuentra un cliente con el Rut especificado, se devuelve el índice de ese cliente en la lista; de lo contrario, se devuelve -1.
        /// </remarks>
        private int ObtenerCliente(string rutCliente)
        {
            foreach (Cliente cliente in clientes)
            {
                if (rutCliente == cliente.RutCliente)
                {
                    return clientes.IndexOf(cliente);
                }
            }
            return -1;
        }


        /// <summary>
        /// Elimina un cliente y sus vehículos y mantenciones asociadas a partir de su número de Rut.
        /// </summary>
        /// <remarks>
        /// Este método permite eliminar un cliente y todos los vehículos y mantenciones asociadas a ese cliente.
        /// Para ello, se solicita el número de Rut del cliente a eliminar. Si se encuentra el cliente con ese Rut,
        /// se eliminan sus vehículos y mantenciones asociadas, y finalmente, se elimina el cliente de la lista de clientes.
        /// </remarks>
        private void EliminarCliente()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            Console.WriteLine("Ingrese el rut del Cliente para eliminarlo, se eliminará el vehículo asociado y la mantención asociada.");
            string rutCliente = Console.ReadLine();
            int index = ObtenerCliente(rutCliente);
            if (index >= 0)
            {
                // Elimina el cliente de la lista
                clientes.RemoveAt(index);
                foreach (Vehiculo a in vehiculos)
                {
                    if (a.Dueno == clientes[index])
                    {
                        foreach (InfoReparacionMantencion b in info)
                        {
                            if (a.Patente == b.Patente)
                            {
                                info.Remove(b);
                            }
                        }
                        vehiculos.Remove(a);
                    }
                }

                Console.WriteLine("Cliente eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado. Verifique el RUT ingresado.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Permite editar la información de un cliente a partir de su número de Rut.
        /// </summary>
        /// <remarks>
        /// Este método permite editar la información de un cliente, como el Rut, la Razón Social, la Dirección y el Teléfono.
        /// El usuario proporciona el número de Rut del cliente que desea editar y se le ofrece un menú para elegir qué campo
        /// de información desea modificar. Luego de la modificación, se almacenan los cambios en el cliente correspondiente.
        /// </remarks>
        private void EditarCliente()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            Console.WriteLine("Ingrese el RUT del Cliente que desea editar:");
            string rutCliente = Console.ReadLine();
            int index = ObtenerCliente(rutCliente);
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado el cliente.");
            }
            else
            {
                // Menú para elegir qué se desea modificar, se realiza a través de los métodos Set y Get respectivos.
                Console.WriteLine("Elija lo que quiere editar: \n 1.- Rut. \n 2.- Razon Social. \n 3.- Direccion. \n 4.- Telefono. \n 5.- Salir");
                int opcion = int.Parse(Console.ReadLine());
                bool salir = false;

                while (salir == false)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            clientes[index].RutCliente = Console.ReadLine();
                            Console.ReadKey();
                            salir = true;
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            clientes[index].RazonSocial = Console.ReadLine();
                            salir = true;
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            clientes[index].Direccion = Console.ReadLine();
                            salir = true;
                            break;
                        case 4:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            clientes[index].TelefonoCliente = Console.ReadLine();
                            salir = true;
                            break;
                        case 5:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elija una opción válida.");
                            break;
                    }
                }
            }
            Console.ReadKey();
        }


        //---------------------Empleado-----------------------------------------------

        /// <summary>
        /// Permite agregar un nuevo empleado al sistema.
        /// </summary>
        /// <remarks>
        /// Este método permite agregar un nuevo empleado al sistema. El usuario proporciona información sobre el nombre,
        /// el número de Rut y el teléfono del empleado. Una vez ingresada la información, se crea una instancia de la
        /// clase Empleado y se agrega a la lista de empleados en el sistema.
        /// </remarks>
        private void AgregarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            Console.WriteLine("Informacion del nuevo Empleado: ");
            Console.WriteLine();

            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Rut: ");
            string rutEmpleado = Console.ReadLine();

            Console.WriteLine("Telefono: ");
            string telefonoEmpleado = Console.ReadLine();

            Empleado empleado = new Empleado(nombre, rutEmpleado, telefonoEmpleado);
            empleados.Add(empleado);
        }

        /// <summary>
        /// Lista todos los empleados registrados en el sistema.
        /// </summary>
        /// <remarks>
        /// Este método muestra en la consola la información de todos los empleados registrados en el sistema. 
        /// Itera a través de la lista de empleados y muestra los detalles de cada empleado, incluyendo nombre, Rut y teléfono.
        /// </remarks>
        private void ListarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            int n = 1;
            Console.Clear();

            // Itera a través de la lista de empleados y muestra la información de cada empleado en la consola.
            foreach (Empleado a in empleados)
            {
                Console.WriteLine("---------------- Empleado " + n + " -----------------");
                a.ObtenerInfoEmpleado();
                n++;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Obtiene el índice de un empleado en la lista de empleados por su número de Rut.
        /// </summary>
        /// <param name="rutEmpleado">El número de Rut del empleado a buscar.</param>
        /// <returns>El índice del empleado en la lista de empleados o -1 si no se encuentra.</returns>
        /// <remarks>
        /// Este método busca un empleado en la lista de empleados por su número de Rut y devuelve su índice en la lista.
        /// Si el empleado con el número de Rut especificado se encuentra en la lista, se devuelve su índice.
        /// Si el empleado no se encuentra en la lista, se devuelve -1.
        /// </remarks>
        /// <example>
        /// <code>
        /// int index = ObtenerEmpleado("12345678-9");
        /// if (index >= 0)
        /// {
        ///     Console.WriteLine("Empleado encontrado en el índice: " + index);
        /// }
        /// else
        /// {
        ///     Console.WriteLine("Empleado no encontrado.");
        /// }
        /// </code>
        /// </example>
        private int ObtenerEmpleado(string rutEmpleado)
        {
            foreach (Empleado empleado in empleados)
            {
                if (rutEmpleado == empleado.RutEmpleado)
                {
                    return empleados.IndexOf(empleado);
                }
            }
            return -1;
        }

        /// <summary>
        /// Elimina un empleado de la lista de empleados y las mantenciones asociadas.
        /// </summary>
        /// <remarks>
        /// Este método permite eliminar un empleado de la lista de empleados y, al hacerlo, también elimina todas las mantenciones asociadas a ese empleado de la lista de mantenciones.
        /// </remarks>
        /// <example>
        /// <code>
        /// EliminarEmpleado();
        /// </code>
        /// </example>
        private void EliminarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            Console.WriteLine("Ingrese el rut del Empleado para eliminarlo, se eliminarán las mantenciones asociadas.");
            string rutEmpleado = Console.ReadLine();
            int index = ObtenerEmpleado(rutEmpleado);
            if (index >= 0)
            {
                // Elimina el empleado de la lista
                empleados.RemoveAt(index);
                // Elimina las mantenciones asociadas al empleado eliminado
                for (int i = info.Count - 1; i >= 0; i--)
                {
                    if (info[i].Empleado == empleados[index])
                    {
                        info.RemoveAt(i);
                    }
                }
                Console.WriteLine("Empleado eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado. Verifique el RUT ingresado.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Permite editar los datos de un empleado en la lista de empleados.
        /// </summary>
        /// <remarks>
        /// Este método permite al usuario editar los datos de un empleado específico en la lista de empleados, como nombre, RUT y número de teléfono.
        /// </remarks>
        /// <example>
        /// <code>
        /// EditarEmpleado();
        /// </code>
        /// </example>
        private void EditarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            Console.WriteLine("Ingrese el RUT del empleado que desea editar:");
            string rut = Console.ReadLine();
            int index = ObtenerEmpleado(rut);
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado el empleado.");
            }
            else
            {
                // Menú para elegir qué se desea modificar, se realiza a través de los métodos Set y Get respectivos.
                Console.WriteLine("Elija lo que quiere editar: \n 1.- Nombre. \n 2.- Rut. \n 3.- Telefono. \n 4.- Salir");
                int opcion = int.Parse(Console.ReadLine());
                bool salir = false;

                while (salir == false)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            empleados[index].Nombre = Console.ReadLine();
                            Console.ReadKey();
                            salir = true;
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            empleados[index].RutEmpleado = Console.ReadLine();
                            salir = true;
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            empleados[index].TelefonoEmpleado = Console.ReadLine();
                            salir = true;
                            break;
                        case 4:
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elija una opción válida.");
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
        //--------------GUARDAR TXT--------------------------------
        private void GuardarInfoEnArchivo()
        {

            StreamWriter writer = new StreamWriter("Guardado.txt");

            writer.WriteLine(clientes.Count);
            for (int i = 0; i < clientes.Count; i++)
            {
                writer.WriteLine(clientes[i].RazonSocial);
                writer.WriteLine(clientes[i].RutCliente);
                writer.WriteLine(clientes[i].Direccion);
                writer.WriteLine(clientes[i].TelefonoCliente);
                writer.WriteLine(clientes[i].Email);
            }

            writer.WriteLine(empleados.Count);
            for (int i = 0; i < empleados.Count; i++)
            {
                writer.WriteLine(empleados[i].Nombre);
                writer.WriteLine(empleados[i].RutEmpleado);
                writer.WriteLine(empleados[i].TelefonoEmpleado);
            }

            writer.WriteLine(vehiculos.Count);
            for (int i = 0; i < vehiculos.Count; i++)
            {
                writer.WriteLine(vehiculos[i].Marca);
                writer.WriteLine(vehiculos[i].Modelo);
                writer.WriteLine(vehiculos[i].Patente);
                writer.WriteLine(vehiculos[i].Color);
                writer.WriteLine(vehiculos[i].Ano);
            }

            writer.WriteLine(piezas.Count);
            for (int i = 0; i < piezas.Count; i++)
            {
                writer.WriteLine(piezas[i].IdentificadorUnico);
                writer.WriteLine(piezas[i].CostoUnitario);
                writer.WriteLine(piezas[i].Marca);
                writer.WriteLine(piezas[i].Proveedor);
            }

            //Mantenciones
            writer.WriteLine(info.Count);
            foreach (InfoReparacionMantencion mantencion in info)
            {
                writer.WriteLine(mantencion.Empleado);
                writer.WriteLine(mantencion.Patente);
                writer.WriteLine(mantencion.Kilometraje);
                writer.WriteLine(mantencion.Inspeccion);
                writer.WriteLine(mantencion.Trabajo);
                writer.WriteLine(mantencion.FechaIngreso);
                writer.WriteLine(mantencion.Entregado);
                writer.WriteLine(mantencion.FechaEntrega);

                writer.WriteLine(mantencion.ListaPiezas.Count);
                foreach (Piezas parte in mantencion.ListaPiezas)
                {
                    writer.WriteLine(parte.IdentificadorUnico);
                    writer.WriteLine(parte.CostoUnitario);
                    writer.WriteLine(parte.Marca);
                    writer.WriteLine(parte.Proveedor);
                }




            }

            writer.Close();
        }



        private void CargarInfoDesdeArchivo()
        {
            string[] lineas = File.ReadAllLines("Guardado.txt");
            int Aux = 0;


            int CantidadDeClientes = int.Parse(lineas[Aux]); Aux++;

            for (int i = 0; i < CantidadDeClientes; i++)
            {
                string RazonSocial = lineas[Aux]; Aux++;
                string Rut = lineas[Aux]; Aux++;
                string Direccion = lineas[Aux]; Aux++;
                string Telefono = lineas[Aux]; Aux++;
                string Email = lineas[Aux]; Aux++;

                Cliente bueno = new Cliente(RazonSocial, Rut, Direccion, Telefono, Email);
                clientes.Add(bueno);
            }


            int CantidadDeEmpleados = int.Parse(lineas[Aux]); Aux++;

            for (int i = 0; i < CantidadDeEmpleados; i++)
            {
                string Nombre = lineas[Aux]; Aux++;
                string Rut = lineas[Aux]; Aux++;
                string TelefonoEmpleado = lineas[Aux]; Aux++;

                Empleado bueno = new Empleado(Nombre, Rut, TelefonoEmpleado);
                empleados.Add(bueno);
            }


            int CantidadDeVehiculos = int.Parse(lineas[Aux]); Aux++;

            for (int i = 0; i < CantidadDeVehiculos; i++)
            {
                string Marca = lineas[Aux]; Aux++;
                string Modelo = lineas[Aux]; Aux++;
                string Patente = lineas[Aux]; Aux++;
                string Color = lineas[Aux]; Aux++;
                int Ano = int.Parse(lineas[Aux]); Aux++;
                string RazonSocial = lineas[Aux]; Aux++; // Suponiendo que la razón social del cliente dueño está en el archivo

                // Buscar el cliente por razón social (esto asume que las razones sociales de los clientes son únicas)
                Cliente Dueno = clientes.FirstOrDefault(c => c.RazonSocial == RazonSocial);

                if (Dueno != null)
                {

                    Vehiculo bueno = new Vehiculo(Marca, Modelo, Patente, Color, Ano, Dueno);
                    vehiculos.Add(bueno);
                }

            }

            int CantidadDePartesOPiezas = int.Parse(lineas[Aux]); Aux++;

            for (int i = 0; i < CantidadDePartesOPiezas; i++)
            {
                string IdentificadorUnico = lineas[Aux]; Aux++;
                string CostoUnitario = lineas[Aux]; Aux++;
                string Marca = lineas[Aux]; Aux++;
                string Proveedor = lineas[Aux]; Aux++;

                Piezas bueno = new Piezas(IdentificadorUnico, Marca, Proveedor, CostoUnitario);
                piezas.Add(bueno);
            }



            int CantidadDeMantenciones = int.Parse(lineas[Aux]); Aux++;

            for (int i = 0; i < CantidadDeMantenciones; i++)
            {
                string Patente = lineas[Aux]; Aux++;
                string Kilometraje = lineas[Aux]; Aux++;
                string Inspeccion = lineas[Aux]; Aux++;
                string Trabajo = lineas[Aux]; Aux++;
                string Fecha = lineas[Aux]; Aux++;
                bool entregado = bool.Parse(lineas[Aux]); Aux++;
                string FechaEntrega = lineas[Aux]; Aux++;

                // Cargar el empleado (supongamos que se almacena el nombre del empleado en el archivo)
                string NombreEmpleado = lineas[Aux]; Aux++;

                // Buscar el empleado por nombre (esto asume que los nombres de empleados son únicos)
                Empleado empleado = empleados.FirstOrDefault(e => e.Nombre == NombreEmpleado);
                if (empleado == null)
                {

                    empleado = new Empleado(NombreEmpleado, "", "");
                }


                int CantidadParteOPiezas = int.Parse(lineas[Aux]); Aux++;

                List<Piezas> piezas = new List<Piezas>();
                for (int j = 0; j < CantidadParteOPiezas; j++)
                {
                    string IdentificadorUnico = lineas[Aux]; Aux++;
                    string CostoUnitario = lineas[Aux]; Aux++;
                    string Marca = lineas[Aux]; Aux++;
                    string Proveedor = lineas[Aux]; Aux++;

                    Piezas nuevo = new Piezas(IdentificadorUnico, Marca, Proveedor, CostoUnitario);
                    piezas.Add(nuevo);
                }




                InfoReparacionMantencion bueno = new InfoReparacionMantencion(Patente, Kilometraje, Inspeccion, Trabajo, Fecha, piezas,entregado, empleado, FechaEntrega);
                info.Add(bueno);




            }
        }




    }
}



    

