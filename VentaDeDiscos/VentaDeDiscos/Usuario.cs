using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeDiscos
{
    class Usuario
    {
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

        string Tipo;

        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        string Codigo;

        public string codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        private static Usuario instance = null;

        public static Usuario getInstance()
        {
            if (instance == null)
            {
                instance = new Usuario();
            }
            return instance;
        }
    }
}
