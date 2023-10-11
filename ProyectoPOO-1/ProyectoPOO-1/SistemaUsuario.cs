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
        private void AgregarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Informacion del nuevo vehiculo: ");

            string patente = Console.ReadLine();
            if (ExisteVehiculo(patente) == true)
            {
                Console.WriteLine("Ese vehiculo ya existe");

            }
            else
            {
                string marca = Console.ReadLine();
                string modelo = Console.ReadLine(); ;
                string color = Console.ReadLine(); ;
                int ano = int.Parse(Console.ReadLine());

                Vehiculo vehiculo = new Vehiculo(marca, patente, modelo, color, ano);
                vehiculos.Add(vehiculo);
            }
        }
        private void EditarVehiculo()
        {

            // Se limpia la consola y se pide el identificador respectivo
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehiculo a modificar:");
            string patente = Console.ReadLine();
            //Se comprueba si existe el identicador
            int index = ObtenerVehiculo(patente);
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado el vehiculo.");
            }
            else
            {
                //Menu para elegir que se desea modificar, se modifica con los SetGet respectivos.
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
                            salir = true; break;
                        case 2:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Marca = Console.ReadLine();
                            salir = true; break;
                        case 3:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Modelo = Console.ReadLine();
                            salir = true; break;
                        case 4:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Color = Console.ReadLine();
                            salir = true; break;
                        case 5:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            vehiculos[index].Ano = int.Parse(Console.ReadLine());
                            salir = true; break;
                        case 6:
                            salir = true; break;
                        default:
                            Console.WriteLine("Elija una opcion valida."); break;
                        }
                }
            }
        }

        private void EliminarVehiculo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehiculo a eliminar:");
            string patente = Console.ReadLine();
            int index = ObtenerVehiculo(patente);
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado el vehiculo.");
            }
            else
            {
                vehiculos.RemoveAt(index);
                Console.WriteLine("El vehiculo se ha eliminado correctamente");
            }
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
            return -1;
        }

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

        private void AgregarPiezas()
        {
            Console.Clear();
            Console.WriteLine("Informacion de la nueva Pieza/Parte");

            Console.WriteLine("Ingrese el identificador unico de la pieza:");
            string identificadorUnico = Console.ReadLine();
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

                Piezas pieza = new Piezas(identificadorUnico, marcaPieza, proveedor, costoUnitario);
                piezas.Add(pieza);
            }
        }

        private void EditarPiezas()
        {
            // Se limpia la consola y se pide el identificador respectivo
            Console.Clear();
            Console.WriteLine("Ingrese el identificador unico de la pieza a modificar:");
            string id = Console.ReadLine();
            //Se comprueba si existe el identicador
            int index = ObtenerPiezas(id);
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado la pieza.");
            }
            else
            {
                //Menu para elegir que se desea modificar, se modifica con los SetGet respectivos.
                Console.WriteLine("Elija lo que quiere editar: \n 1.- Identificador Unico. \n 2.- Marca. \n 3.- Proveedor. \n 4.- Costo Unitario. \n 5.- Salir");
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
                            salir = true; break;
                        case 2:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            piezas[index].Marca = Console.ReadLine();
                            salir = true; break;
                        case 3:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            piezas[index].Proveedor = Console.ReadLine();
                            salir = true; break;
                        case 4:
                            Console.WriteLine("Ingrese el nuevo dato:");
                            piezas[index].CostoUnitario = Console.ReadLine();
                            salir = true; break;
                        case 5:
                            salir = true; break;
                        default:
                            Console.WriteLine("Elija una opcion valida."); break;
                    }
                }
            }
        }

        private void EliminarPiezas()
        {

            Console.Clear();
            Console.WriteLine("Ingrese el identificador unico de la pieza/parte a eliminar:");
            string id = Console.ReadLine();
            int index = ObtenerPiezas(id);

            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado la pieza.");
            }
            else
            {
                piezas.RemoveAt(index);
                Console.WriteLine("La pieza se ha eliminado correctamente");
            }
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
            return -1;
        }

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

        private void AgregarMantencion()
        {
            //Se limpia la lista de piezas de mantencion para reutilizarla.
            piezasMantencion.Clear();
            Console.Clear();
            Console.WriteLine("A continuacion ingrese la informacion correspondiente a la mantencion:");

            //Verifica si una mantencion ya tiene esa patente
            string patente;
            while (true)
            {
                Console.WriteLine("Ingrese la patente del vehiculo a realizar la mantencion:");
                patente = Console.ReadLine();
                if (ExisteMantencion(patente) == true)
                {
                    Console.WriteLine("Ese vehiculo ya tiene una mantencion designada");
                }
                else
                {
                    break;
                }
            }

            //Se pide el empleado a cargo.
            Console.WriteLine("Ingrese el empleado a cargo de la mantencion:");
            bool salirmantencion = false;
            while (salirmantencion == false)
            {
                //Mini menu para ingresar un empleado nuevo o ya existente
                Console.WriteLine("1.- Ingresar empleado existente. \n 2.- Ingresar empleado nuevo");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el rut del empleado");
                        string rut = Console.ReadLine();
                        int index = ObtenerEmpleado(rut);
                        if (index < 0) { Console.WriteLine("No se encontro el empleado."); break; }
                        nuevoEmpleado = empleados[index];
                        salirmantencion = true;
                        break;
                    case 2:
                        AgregarEmpleado();
                        nuevoEmpleado = empleados.Last();
                        salirmantencion = true;
                        break;
                    default:
                        Console.WriteLine("Elija una opcion valida.");
                        break;
                }
                Console.Clear();
            }
            Console.WriteLine("Ingrese el kilometraje");
            string kilometraje = Console.ReadLine();

            Console.WriteLine("Ingrese la descripcion de la inspeccion visual");
            string inspeccion = Console.ReadLine();

            Console.WriteLine("Ingrese el trabajo a realizar:");
            string trabajo = Console.ReadLine();

            //Ingresar fecha de ingreso en formato año mes dia.
            string fechaIngreso;
            while (true)
            {
                Console.WriteLine("Ingrese la fecha de ingreso del vehiculo en formato AAAA-MM-DD:");
                fechaIngreso = Console.ReadLine();

                if (DateTime.TryParseExact(fechaIngreso, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                {
                    Console.WriteLine("Fecha ingresada válida: " + fecha.ToString("yyyy-MM-dd")); break;
                }
                else
                {
                    Console.WriteLine("Fecha ingresada no válida.");
                }
            }


            //While para crear un menu donde agregar las piezas a utilizar.
            salirmantencion = false;
            while (salirmantencion == false)
            {
                Console.WriteLine("A continuacion debera ingresar las partes/piezas que serán utilizadas en la mantencion");
                Console.WriteLine("1.- Ingresar pieza nueva. \n 2.- Ingresar pieza existente. \n 3.- Terminar de elegir piezas");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AgregarPiezas();
                        Piezas ultimaPieza = piezas.Last();
                        piezasMantencion.Add(ultimaPieza);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el identificador unico de la pieza:");
                        string id = Console.ReadLine();
                        int index = ObtenerPiezas(id);
                        if (index < 0) { Console.WriteLine("No se encontro la pieza."); break; }
                        Piezas pieza1 = piezas[index];
                        piezasMantencion.Add(pieza1);
                        break;
                    case 3:
                        salirmantencion = true;
                        break;
                    default:
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }
            }
            bool nuevoEntrega;
            //Pregunta si fue entregado para el bool "Entregado" que se usa en mantenciones.
            while (true)
            {
                Console.WriteLine("¿El vehiculo fue entregado? \n 1.- Entregado. \n 2.- No entregado.");

                int opcionEntrega = int.Parse(Console.ReadLine());
                if (opcionEntrega == 1) { nuevoEntrega = true; break; }
                if (opcionEntrega == 2) { nuevoEntrega = false; break; }
                else { Console.WriteLine("Elija una opcion valida."); }
            }

            //Se agrega
            InfoReparacionMantencion Mantencion = new InfoReparacionMantencion(patente, kilometraje, inspeccion, trabajo, fechaIngreso, piezasMantencion, nuevoEntrega, nuevoEmpleado);
            info.Add(Mantencion);

        }


        private void EditarMantencion()
        {
            // Se limpia la consola y se pide el identificador respectivo
            Console.Clear();
            Console.WriteLine("Ingrese la patente de la mantencion a modificar:");
            string id = Console.ReadLine();
            //Se comprueba si existe el identicador
            int index = ObtenerMantencion(id);
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado la mantencion.");
            }
            else
            {
                //Menu para elegir que se desea modificar, se modifica con los SetGet respectivos.
                Console.WriteLine("Elija lo que quiere editar: \n 1.- Patente. \n 2.- Kilometraje. \n 3.- Inspeccion Visual. \n 4.- Trabajo. \n 5.- Fecha Ingreso");
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
                                Console.WriteLine("Ingrese la fecha de ingreso del vehiculo en formato AAAA-MM-DD:");
                                auxiliar = Console.ReadLine();

                                if (DateTime.TryParseExact(auxiliar, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                                {
                                    Console.WriteLine("Fecha ingresada válida: " + fecha.ToString("yyyy-MM-dd")); break;
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
                                Console.WriteLine("A continuacion podra editar las partes/piezas que serán utilizadas en la mantencion");
                                Console.WriteLine("1.- Ingresar pieza nueva. \n 2.- Ingresar pieza existente. \n 3.- Eliminar piezas.\n 4.- Editar piezas. \n 5.- Salir");
                                opcion = int.Parse(Console.ReadLine());
                                switch (opcion)
                                {
                                    case 1:
                                        AgregarPiezas();
                                        Piezas ultimaPieza = piezas.Last();
                                        piezasMantencion.Add(ultimaPieza);
                                        salir = true;  break;
                                    case 2:
                                        Console.WriteLine("Ingrese el identificador unico de la pieza:");
                                        idAuxiliar = Console.ReadLine();
                                        indexAuxiliar = ObtenerPiezas(id);
                                        if (index < 0) { Console.WriteLine("No se encontro la pieza."); break; }
                                        Piezas pieza1 = piezas[index];
                                        piezasMantencion.Add(pieza1);
                                        salir = true;  break;
                                    case 3:
                                        Console.WriteLine("Ingrese el identificador unico de la pieza:");
                                        idAuxiliar = Console.ReadLine();
                                        indexAuxiliar = ObtenerPiezas(id);
                                        if (index < 0) { Console.WriteLine("No se encontro la pieza."); break; }
                                        piezasMantencion.RemoveAt(index);
                                        salir = true;  break;

                                    case 4:
                                        // Se limpia la consola y se pide el identificador respectivo
                                        Console.Clear();
                                        Console.WriteLine("Ingrese el identificador unico de la pieza a modificar:");
                                        idAuxiliar = Console.ReadLine();
                                        //Se comprueba si existe el identicador
                                        indexAuxiliar = ObtenerPiezas(id);
                                        if (index < 0)
                                        {
                                            Console.WriteLine("No se ha encontrado la pieza.");
                                        }
                                        else
                                        {
                                            //Menu para elegir que se desea modificar, se modifica con los SetGet respectivos.
                                            Console.WriteLine("Elija lo que quiere editar: \n 1.- Identificador Unico. \n 2.- Marca. \n 3.- Proveedor. \n 4.- Costo Unitario. \n 5.- Salir");
                                            opcion = int.Parse(Console.ReadLine());
                                            salir = false;
                                            while (salir == false)
                                            {
                                                switch (opcion)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Ingrese el nuevo dato:");
                                                        piezasMantencion[index].IdentificadorUnico = Console.ReadLine();
                                                        Console.ReadKey();
                                                        salir = true; break;
                                                    case 2:
                                                        Console.WriteLine("Ingrese el nuevo dato:");
                                                        piezasMantencion[index].Marca = Console.ReadLine();
                                                        salir = true; break;
                                                    case 3:
                                                        Console.WriteLine("Ingrese el nuevo dato:");
                                                        piezasMantencion[index].Proveedor = Console.ReadLine();
                                                        salir = true; break;
                                                    case 4:
                                                        Console.WriteLine("Ingrese el nuevo dato:");
                                                        piezasMantencion[index].CostoUnitario = Console.ReadLine();
                                                        salir = true; break;
                                                    case 5:
                                                        salir = true; break;
                                                    default:
                                                        Console.WriteLine("Elija una opcion valida."); break;
                                                }
                                            }
                                        } break;
                                    
                                    case 5:
                                        salir = true; break;
                                    default:
                                        Console.WriteLine("Elija una opcion valida");
                                        break;
                                }
                             
                            } break;

                        case 7:
                            if (info[index].Entregado == false)
                            {
                                Console.WriteLine("Este vehiculo no ha sido entregado ¿Desea establecerlo como entregado? Si/No");
                                string entrega = Console.ReadLine();
                                if (entrega == "Si" || entrega == "si")
                                {
                                    info[index].Entregado = true;

                                    while (true)
                                    {
                                        Console.WriteLine("Ingrese la fecha de entrega del vehiculo en formato AAAA-MM-DD:");
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
                                Console.WriteLine("El vehiculo fue entregado el: " + info[index].FechaEntrega);
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
                                                Console.WriteLine("Ingrese la fecha de entrega del vehiculo en formato AAAA-MM-DD:");
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
                                            Console.WriteLine("Elija una opcion valida."); break;
                                    }
                                }

                            }
                            break;

                        case 8:
                            Console.WriteLine("El empleado a cargo es: " + info[index].Empleado.Nombre);

                            salir = false;
                            while (salir == false)
                            {




                            }



                            break;
                        case 9:
                            salir = true; break;
                        default:
                            Console.WriteLine("Elija una opcion valida."); break;
                    }
                }
            }



        }

        private void EliminarMantencion()
        {
            Console.WriteLine("Ingrese la patente de la mantencion que desea eliminar");
            string patente = Console.ReadLine();
            int index = ObtenerMantencion(patente);
            if (index < 0)
            {
                Console.WriteLine("No se encontro la mantencion.");
            }
            else
            {
                info.RemoveAt(index);
                Console.WriteLine("Se ha eliminado la mantencion exitosamente.");
            }
        }
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

        private void MantencionesNoCompletadas()
        {
            int i = 0;
            int j = 0;
            //Si no hay mantenciones
            if(info.Count <= 0)
            {
                Console.WriteLine("No hay mantenciones registradas.");
            }
            else
            {
                foreach (InfoReparacionMantencion M in info)
                {
                    i++;
                    //Se revisa si el bool Entregado en false, si lo el vehiculo no ha sido entregado y se imprime la informacion en pantalla
                    if (M.Entregado == false)
                    {

                        Console.WriteLine("---------------- Vehiculo " + i + "------------------");
                        M.ObtenerInformacion();

                    }
                    else { j++; } //Se suma j si el vehiculo fue entregado.
                }
                //Si j es igual a la cantidad de elementos en info eso significa que todos los vehiculos fueron entregados.
                if (j == info.Count)
                {
                    Console.WriteLine("Todos los vehiculos registrados fueron entregados");
                }
            }
            
            Console.ReadKey();
        }

        private void TodasMantenciones()
        {
            Console.Clear();
            Console.WriteLine("A continuacion se listarán todos los vehículos con sus mantenciones realizadas y partes o piezas \n utilizadas, ordenados por fecha de ingreso.");

            //Se crea lista donde se guardarán el orden
            List<string> ordenIngreso = new List<string>();

            foreach (InfoReparacionMantencion x in info)
            {
                //Se guardan todas las fechas de ingreso en la lista ordenIngreso
                ordenIngreso.Add(x.FechaIngreso);
            }
            // Se ordenan las fechas con OrderBy y se envian de vuelta a la lista orden
            var fechasOrdenadas = ordenIngreso.OrderBy(fecha => fecha).ToList();

            //Se crean las variables i y j para su uso en el while
            int i = 0;
            int j = 0;
            while (true)
            {
                
                foreach (InfoReparacionMantencion y in info)
                {
                    //Se comprueba si la fecha de ingreso de y es igual al index i de ordenIngreso
                    if (y.FechaIngreso == ordenIngreso[i])
                    {
                        //Se imprime la informacion del vehiculo y se aumenta i 
                        Console.WriteLine("----------- Vehiculo " + (i + 1) + "-------------");
                        y.ObtenerInformacion();
                        i++;
                    }
                }
                j++;
                //Se compruba si j es mayor o igual a la cantidad de elementos de ordenIngreso, si es igual se romple el ciclo.
                if (j >= ordenIngreso.Count - 1)
                {
                    break;
                }
                
            }
            Console.ReadKey();
        }


        private void EmpleadosMantenciones()
        {
            Console.Clear();
            Console.WriteLine("A continuacion se listaran todos los empleados, con sus mantenciones o reparaciones realizadas, \nordenadas por duración de la mantención");
            foreach (Empleado x in empleados)
            {
                //Se crean dos listas que se usaran para ordenar los datos
                List<InfoReparacionMantencion> mantenciones = new List<InfoReparacionMantencion>();
                List<InfoReparacionMantencion> mantencionesOrdenadas = new List<InfoReparacionMantencion>();
                List<int> orden = new List<int>();

                //Se agregan las mantenciones que corresponden al empleado a la lista mantenciones
                foreach (InfoReparacionMantencion y in info)
                {
                    if (y.Empleado == x)
                    {
                        mantenciones.Add(y);
                    }
                }

                //Se revisa si el vehiculo fue entregado, de ser así se llama a DiferenciaFechas y se agrega a la lista orden.
                foreach (InfoReparacionMantencion w in mantenciones)
                {
                    if (w.Entregado == true)
                    {
                        orden.Add(w.DiferenciaFechas());
                        mantencionesOrdenadas.Add(w);
                    }

                }

                //Se ordenan las diferencias de dias de menor a mayor.
                orden.OrderBy(diferencia => diferencia).ToList();

                //Se imprime el nombre del empleado, se crean las variables i y j y se inician en 0.
                Console.Write("---- " + x.Nombre + " ----\n");
                int i = 0;
                int j = 0;
                while (true)
                {
                    //Se vuelve a poner i en 0          
                    if (j >= orden.Count) // Si j es mayor al Count de orden, significa que ya se revisaron todos los elementos de orden.
                    {
                        break;
                    }
                    foreach (InfoReparacionMantencion z in mantencionesOrdenadas)
                    //Se revisa si el elemento i de orden es igual a la diferencia de cualquier mantencion.
                    {
                        //Se comprueba si diferencia de fechas de z es igual al index i de ordenIngreso
                        if (z.DiferenciaFechas() == orden[i])
                        {
                            Console.WriteLine("----------- Mantencion " + (i + 1) + "-------------");
                            z.ObtenerInformacion();
                           Console.WriteLine("La mantencion ha durado: " + z.DiferenciaFechas() + " días.");
                            i++;
                        }
                    }
                    j++;

                    //Imprimir mantenciones no terminadas)?
                    foreach (InfoReparacionMantencion w in mantenciones)
                    {
                        Console.WriteLine("Las siguientes vehiculos no fueron entregados.");
                        if (w.Entregado != true)
                        {
                            Console.WriteLine("-------------- Vehiculo " + (i + 1) + " --------------------");
                            w.ObtenerInformacion();
                            i++;
                        }
                    }
                    Console.ReadKey();
                    mantenciones.Clear();   
                }
            }

        }

        //-----------------------------CLIENTE----------------------
        private void AgregarCliente()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
            Console.WriteLine("Informacion del nuevo Cliente: ");
            Console.WriteLine("");

            Console.Write("Rut: ");
            string rutCliente = Console.ReadLine();
            Console.Write("Razon Social: ");
            string razonSocial = Console.ReadLine();
            Console.Write("Direccion: ");
            string direccion = Console.ReadLine();
            Console.Write("Telefono: ");
            string telefonoCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(razonSocial, rutCliente, direccion, telefonoCliente, email);

            clientes.Add(cliente);
        }

        private void ListarCliente()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
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
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
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
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
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
        private void ListarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
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
            return -1;
        }
        private void EliminarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
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
            Console.Clear();
            Console.WriteLine("-------------------IDVRV-------------------");
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
        //--------------GUARDAR TXT--------------------------------
        private void GuardarInfoEnArchivo()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del archivo para guardar los datos: ");
            string archivo = Console.ReadLine().Trim();

            using (StreamWriter writer = new StreamWriter(archivo))
            {
                // Empleados
                writer.WriteLine(empleados.Count);
                foreach (var empleado in empleados)
                {
                    writer.WriteLine("Empleados");
                    writer.WriteLine(empleado.RutEmpleado);
                    writer.WriteLine(empleado.Nombre);
                    writer.WriteLine(empleado.TelefonoEmpleado);
                    writer.WriteLine();
                }

                // Clientes
                writer.WriteLine(clientes.Count);
                foreach (var cliente in clientes)
                {
                    writer.WriteLine("Clientes");
                    writer.WriteLine(cliente.RazonSocial);
                    writer.WriteLine(cliente.RutCliente);
                    writer.WriteLine(cliente.Direccion);
                    writer.WriteLine(cliente.TelefonoCliente);
                    writer.WriteLine(cliente.Email);
                    writer.WriteLine();

                }

                // Vehiculos
                writer.WriteLine(vehiculos.Count);
                foreach (var vehiculo in vehiculos)
                {
                    writer.WriteLine("Vehiculos");
                    writer.WriteLine(vehiculo.Marca);
                    writer.WriteLine(vehiculo.Patente);
                    writer.WriteLine(vehiculo.Modelo);
                    writer.WriteLine(vehiculo.Color);
                    writer.WriteLine(vehiculo.Ano);
                    writer.WriteLine();
                }

                // Partes o piezas
                writer.WriteLine(piezas.Count);
                foreach (var pieza in piezas)
                {
                    writer.WriteLine("Partes o Piezas");
                    writer.WriteLine(pieza.IdentificadorUnico);
                    writer.WriteLine(pieza.Marca);
                    writer.WriteLine(pieza.Proveedor);
                    writer.WriteLine(pieza.CostoUnitario);
                    writer.WriteLine();
                }

                // Mantencion
                writer.WriteLine(info.Count);
                foreach (var record in info)
                {
                    writer.WriteLine("Mantencion");
                    writer.WriteLine(record.Patente);
                    writer.WriteLine(record.Kilometraje);
                    writer.WriteLine(record.Inspeccion);
                    writer.WriteLine(record.Trabajo);
                    //writer.WriteLine(record.Fecha);
                    writer.WriteLine(record.ListaPiezas);
                    writer.WriteLine(record.Entregado);
                    writer.WriteLine(record.FechaEntrega);
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Datos guardados correctamente.");
        }

        public void CargarInfoDesdeArchivo()
        {

            Console.WriteLine("Ingrese el nombre del archivo para cargar los datos: ");
            string archivo = Console.ReadLine().Trim();

            if (File.Exists(archivo))
            {




                //Cargamos los empleados
                string[] lineas = File.ReadAllLines(archivo);
                int indice = 1;
                int numeroEmpleados = int.Parse(lineas[indice]);

                for (int i = 0; i < numeroEmpleados; i++)
                {
                    string nombre = lineas[indice];
                    indice++;
                    indice++;
                    string rutEmpleado = lineas[indice];
                    indice++;
                    string telefonoEmpleado = lineas[indice];
                    indice++;
                    int edad = int.Parse(lineas[indice]);

                    Empleado empleado = new Empleado(rutEmpleado, nombre, telefonoEmpleado);
                    empleados.Add(empleado);

                }

                indice++;

                //Cargamos los clientes
                int numeroClientes = int.Parse(lineas[indice]);

                for (int i = 0; i < numeroClientes; i++)
                {
                    indice++;
                    string razonSocial = lineas[indice];
                    indice++;
                    string rutCliente = lineas[indice];
                    indice++;
                    string direccion = lineas[indice];
                    indice++;
                    string telefonoCliente = lineas[indice];
                    indice++;
                    string email = lineas[indice];

                    Cliente cliente = new Cliente(razonSocial, rutCliente, direccion, telefonoCliente, email);
                    clientes.Add(cliente);


                }

                Console.WriteLine("Datos cargados correctamente.");
            }
            else
            {
                Console.WriteLine("El archivo no existe. Asegúrese de que el archivo especificado exista.");
            }


        }




    }
}



    

