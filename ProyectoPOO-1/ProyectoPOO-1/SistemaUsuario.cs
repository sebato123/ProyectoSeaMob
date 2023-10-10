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

            while (!salir)
            {
                AgregarEmpleado();
                AgregarMantencion();
                EmpleadosMantenciones();




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
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehiculo a modificar:");
            string patente = Console.ReadLine();
            int index = ObtenerVehiculo(patente);
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado el vehiculo.");
            }
            else
            {
                

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
            Console.Clear();
            Console.WriteLine("Ingrese la patente del vehiculo a modificar:");
            string id = Console.ReadLine();
            int index = ObtenerPiezas(id);
            piezas[index].ObtenerInformacion();
            if (index < 0)
            {
                Console.WriteLine("No se ha encontrado la pieza.");
            }
            else
            {
                
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
                if (id == pieza.IdentificadorUnico )
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
                else {
                    break;
                }
            }
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
                    Console.WriteLine("Fecha ingresada válida: " + fecha.ToString("yyyy-MM-dd"));break;
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
                            if (index < 0) { Console.WriteLine("No se encontro la pieza.");  break; }
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
            foreach(InfoReparacionMantencion A in info)
            {
                if (A.Patente == patente)
                {
                    return true;
                }
            }
            return false;
        }


        //-------------------------------------------------------------------------------


        //---------------FUNCIONES EXTRAS--------------------------

        private void MantencionesNoCompletadas()
        {
            int i = 0;
            Console.Clear();
            foreach(InfoReparacionMantencion M in info)
            {
                if (M.Entregado == false)
                {
                    i++;
                    Console.WriteLine("---------------- Vehiculo " + i + "------------------");
                    M.ObtenerInformacion();
                   
                }
                else
                {
                    Console.WriteLine("Este ");
                }
            }
            Console.ReadKey();  
        }

        private void TodasMantenciones()
        {
            Console.Clear();
            Console.WriteLine("A continuacion se listarán todos los vehículos con sus mantenciones realizadas y partes o piezas \n utilizadas, ordenados por fecha de ingreso.");

            List<string> ordenIngreso = new List<string>();
            
            foreach (InfoReparacionMantencion x in info)
            {
                ordenIngreso.Add(x.FechaIngreso);
            }
            var fechasOrdenadas = ordenIngreso.OrderBy(fecha => fecha).ToList();

            int i = 0;
            int j = 0;
            while (true)
            {
                i = 0;
                if (j >= ordenIngreso.Count)
                {
                    break;
                }
                foreach (InfoReparacionMantencion y in info)
                {
                    if (y.FechaIngreso == ordenIngreso[i])
                    {
                        i++;
                        Console.WriteLine("----------- Vehiculo "+ i + "-------------");
                        y.ObtenerInformacion();
                        
                    }
                }
                j++;
            }
        }


        private void EmpleadosMantenciones()
        {
            Console.Clear();
            Console.WriteLine("A continuacion se listaran todos los empleados, con sus mantenciones o reparaciones realizadas, \nordenadas por duración de la mantención");
            foreach (Empleado x in empleados)
            {
                //Se crean dos listas que se usaran para ordenar los datos
                List<InfoReparacionMantencion> mantenciones = new List<InfoReparacionMantencion>();
                List<int> orden = new List<int>();

                //Se agregan las mantenciones que corresponden al empleado a la lista mantenciones
                foreach(InfoReparacionMantencion y in info)
                {
                    if (y.Empleado == x) 
                    {
                        mantenciones.Add(y);
                    }
                }

                //Se revisa si el vehiculo fue entregado, de ser así se llama a DiferenciaFechas y se agrega a la lista orden.
                foreach(InfoReparacionMantencion w in mantenciones)
                {

                    if (w.Entregado == true)
                    {
                        orden.Add(w.DiferenciaFechas());
                    }
      
                }

                //Se ordenan las diferencias de dias de menor a mayor.
                orden.OrderBy(diferencia => diferencia).ToList();


                //Se imprime el nombre del empleado y se inicializa i y j.
                Console.Write("---- " + x.Nombre + " ----\n");
                int i = 0;
                int j = 0;
                while (true)
                {
                    //Se vuelve a poner i en 0
                    i = 0;
                    if (j >= orden.Count) // Si j es mayor al Count de orden, significa que ya se revisaron todos los elementos de orden.
                    {
                        break;
                    }
                    foreach (InfoReparacionMantencion z in mantenciones)
                    //Se revisa si el elemento i de orden es igual a la diferencia de cualquier mantencion.
                    {
                        if (z.DiferenciaFechas() == orden[i])
                        {
                            i++;
                            Console.WriteLine("----------- Mantencion " + i + "-------------");
                            z.ObtenerInformacion();

                        }
                    }
                    j++;

                    //Imprimir mantenciones no terminadas)?
                    Console.ReadKey();
                }


            }
              
        }




        

















































































        //seaaaa Cliente
        private void AgregarCliente()
        {
            Console.Clear();
            Console.WriteLine("Informacion del nuevo Cliente: ");

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

            Empleado empleado = new Empleado(nombre, rutEmpleado, telefonoEmpleado);
            empleados.Add(empleado);

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
            return -1;
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


    

