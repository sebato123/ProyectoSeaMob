using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class Piezas
    {
        private string identificadorUnico;
        private string marca;
        private string proveedor;
        private string costoUnitario;

        public Piezas(string nuevoIdentificadorUnico, string nuevoMarca, string nuevoProveedor, string nuevoCostoUnitario)
        {
            identificadorUnico = nuevoIdentificadorUnico;
            marca = nuevoMarca;
            proveedor = nuevoProveedor;
            costoUnitario = nuevoCostoUnitario;

        }



        //Getters and Setters
        //--------------------------------------
        public string IdentificadorUnico
        {
            set { identificadorUnico = value; }
            get { return identificadorUnico; }
        }

        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public string Proveedor
        {
            set { proveedor = value; }
            get { return proveedor; }
        }
        public string CostoUnitario
        {
            set { costoUnitario = value; }
            get { return costoUnitario; }
        }
        //--------------------------------------
        public void ObtenerInformacion()
        {
            Console.WriteLine("El identificador Unico es: " + identificadorUnico);
            Console.WriteLine("La marca es: " + marca);
            Console.WriteLine("El proveedor es: " + proveedor);
            Console.WriteLine("El costo unitario es: " + costoUnitario);
            Console.ReadKey();
        }


    }

}
