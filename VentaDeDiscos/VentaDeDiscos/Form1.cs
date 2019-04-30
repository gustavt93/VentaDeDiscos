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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        string sql;

        Usuario usuario;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "SELECT Nom_vendedor, Ape_vendedor, Tipo, Cod_vendedor FROM Usuario WHERE DNI = '" + textBox1.Text + "' AND Contraseña = '" + textBox2.Text + "'";
            dt = conexion.consultar(sql, "Usuario");
            if (dt.Rows.Count != 0)
            {
                usuario = Usuario.getInstance();
                foreach (DataRow row in dt.Rows)
                {
                    usuario.nombre = row[0].ToString();
                    usuario.apellido = row[1].ToString();
                    usuario.tipo = row[2].ToString();
                    usuario.codigo = row[3].ToString();
                }
                MessageBox.Show("Bienvenido:\n" + usuario.nombre + " " + usuario.apellido);
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
