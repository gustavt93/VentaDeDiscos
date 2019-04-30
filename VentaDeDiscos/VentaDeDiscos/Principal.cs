using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaDeDiscos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Usuario usuario = Usuario.getInstance();
        Conexion conexion = Conexion.getInstance();
        Cliente cliente = Cliente.getInstance();
        Disco disco_objeto = Disco.getInstance();

        DataTable dt;
        string sql;
        int reg = 0;
        int count = 0;

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load_1(object sender, EventArgs e)
        {

            if (usuario.tipo == "1")
            {
                configuracionToolStripMenuItem.Enabled = false;
            }

            sql = "SELECT b.Nom_banda, b.Precio, b.Cod_banda, g.Nom_genero " +
            "FROM Banda b, Genero g " +
            "WHERE b.Cod_genero = g.Cod_genero and Estado = 0";

            dt = conexion.consultar(sql, "Banda");

            dataGridView2.DataSource = dt;
            vendedor.Text = usuario.nombre + " " + usuario.apellido;
        }


        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            disco.Text = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString() + " - S/. " + dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void insertarModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InMo inmo = new InMo();
            inmo.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "SELECT Nom_Cliente, Ape_cliente FROM Cliente WHERE DNI = '" + dni.Text + "'";
            dt = conexion.consultar(sql, "Cliente");
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    nombre.Text = dr[0].ToString();
                    apellido.Text = dr[1].ToString();
                    reg = 1;
                }
            }
            else
            {
                MessageBox.Show("Cliente no existente, Ingrese su nombre y apellido");
                nombre.Text = "";
                apellido.Text = "";
                reg = 0;
            }
        }

        private void Limpiar_campos()
        {
            dni.Text = "";
            nombre.Text = "";
            apellido.Text = "";
            disco.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                sql = "SELECT b.Nom_banda, b.Precio, b.Cod_banda, g.Nom_genero FROM Banda b, Genero g WHERE b.Cod_genero = g.Cod_genero and Estado = 0 and g.Nom_genero LIKE '" + textBox2.Text + "' + '%'";
                dt = conexion.consultar(sql, "Banda");
                dataGridView2.DataSource = dt;
            }
            else
            {
                sql = "SELECT Nom_banda, Precio, Cod_banda FROM Banda WHERE Nom_banda LIKE '" + textBox1.Text + "' + '%'";
                dt = conexion.consultar(sql, "Banda");
                dataGridView2.DataSource = dt;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            if (usuario.tipo == "1")
            {
                configuracionToolStripMenuItem.Enabled = false;
            }

            sql = "SELECT b.Nom_banda, b.Precio, b.Cod_banda, g.Nom_genero " +
            "FROM Banda b, Genero g " +
            "WHERE b.Cod_genero = g.Cod_genero and Estado = 0";

            dt = conexion.consultar(sql, "Banda");

            dataGridView2.DataSource = dt;
            vendedor.Text = usuario.nombre + " " + usuario.apellido;

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            cliente.dni = dni.Text;
            cliente.nombre = nombre.Text;
            cliente.apellido = apellido.Text;
            count = conexion.Contador_ventas();

            if (conexion.Realizar_Venta(cliente, disco_objeto, usuario, reg, count))
            {
                MessageBox.Show("VENTA REALIZADA CON EXITO");

                Limpiar_campos();
            }
            else
            {
                MessageBox.Show("NO SE PUDO REALIZAR LA VENTA");
            }
        }

        private void InsertarModificarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InMo inmo = new InMo();
            inmo.Show();
            this.Close();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            sql = "SELECT Nom_Cliente, Ape_cliente FROM Cliente WHERE DNI = '" + dni.Text + "'";
            dt = conexion.consultar(sql, "Cliente");
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    nombre.Text = dr[0].ToString();
                    apellido.Text = dr[1].ToString();
                    reg = 1;
                }
            }
            else
            {
                MessageBox.Show("Cliente no existente, Ingrese su nombre y apellido");
                nombre.Text = "";
                apellido.Text = "";
                reg = 0;
            }
        }
    }
}
