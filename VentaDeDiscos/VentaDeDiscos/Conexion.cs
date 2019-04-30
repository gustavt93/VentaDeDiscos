using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace VentaDeDiscos
{
    class Conexion
    {
        SqlConnection cn;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand cmd;

        private static Conexion instance = null;

        public static Conexion getInstance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }

        public Conexion()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=LAPTOP-MTN36AV2\SQLEXPRESS; Initial Catalog=Discos; Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        public DataTable consultar(string sql, string tabla)
        {
            dt = new DataTable(tabla);

            adapter = new SqlDataAdapter(sql, cn);
            adapter.Fill(dt);
            return dt;
        }

        public bool Realizar_Venta(Cliente cliente, Disco disco_objeto, Usuario usuario, int reg, int con)
        {
            try
            {
                if (reg == 0)
                {
                    Registrar_Cliente(cliente);
                }
                cmd = new SqlCommand("INSERT INTO Venta(Num_venta, Cod_vendedor, Cod_banda, DNI) VALUES ('" + con + "','" + usuario.codigo + "','" + disco_objeto.codigo + "','" + cliente.dni + "')", cn);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return false;
            }
        }

        private bool Registrar_Cliente(Cliente cliente)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Cliente(DNI, Nom_cliente, Ape_cliente) VALUES ('" + cliente.dni + "','" + cliente.nombre + "','" + cliente.apellido + "')", cn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return false;
            }
        }

        public bool Registrar_Disco(Disco disco)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Banda(Cod_banda, Cod_genero, Nom_banda, Precio, Estado) VALUES ('" + disco.codigo + "','" + disco.codigo_genero + "','" + disco.nombre_banda + "', " + disco.precio + ",'" + disco.estado + "');", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Disco registrado");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return false;
            }
        }

        public bool Modificar_disco(Disco disco)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Banda SET Cod_genero = '" + disco.codigo_genero + "', Nom_banda = '" + disco.nombre_banda + "', Precio = '" + disco.precio + "', Estado = '" + disco.estado + "' WHERE Cod_banda = '" + disco.codigo + "'", cn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
                return false;
            }
        }

        public int Contador_ventas()
        {
            int count = 1;
            try
            {
                dt = consultar("SELECT COUNT(*) FROM Venta", "Contador");
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                        count = Convert.ToInt32(dr[0].ToString()) + 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }
            return count;
        }
    }
}
