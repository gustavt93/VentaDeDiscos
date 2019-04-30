using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeDiscos
{
    class Disco
    {
        string Codigo;

        public string codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        string Codigo_genero;

        public string codigo_genero
        {
            get { return Codigo_genero; }
            set { Codigo_genero = value; }
        }

        string Nombre_banda;

        public string nombre_banda
        {
            get { return Nombre_banda; }
            set { Nombre_banda = value; }
        }

        int Precio;

        public int precio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        string Estado;

        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }


        private static Disco instance = null;

        public static Disco getInstance()
        {
            if (instance == null)
            {
                instance = new Disco();
            }
            return instance;
        }
    }
}
