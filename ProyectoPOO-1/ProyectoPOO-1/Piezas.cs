using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO_1
{
    public class Piezas
    {
        private string identificadorUnico;
        private string marca;
        private string proveedor;
        private int costoUnitario;

        public Piezas(string nuevoIdentificadorUnico, string nuevoMarca, string nuevoProveedor, int nuevoCostoUnitario)
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
        public int CostoUnitario
        {
            set { costoUnitario = value; }
            get { return costoUnitario; }
        }
        //--------------------------------------
    }
}
