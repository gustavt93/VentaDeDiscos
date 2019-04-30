using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeDiscos
{
    class Facade
    {
        private Conexion conexion;
        private InMo inmo;

        public void facadeCliente()
        {
            conexion = new Conexion();
            conexion.Contador_ventas();
        }
    }
}
