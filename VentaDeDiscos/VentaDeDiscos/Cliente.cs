using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeDiscos
{
    class Cliente
    {
        string DNI;

        public string dni
        {
            get { return DNI; }
            set { DNI = value; }
        }

        string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        string Apellido;

        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        private static Cliente instance = null;

        public static Cliente getInstance()
        {
            if (instance == null)
            {
                instance = new Cliente();
            }
            return instance;
        }
    }
}
