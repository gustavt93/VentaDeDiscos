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
    public partial class InMo : Form
    {
        public InMo()
        {
            InitializeComponent();
        }

        Conexion conexion = Conexion.getInstance();
        Disco disco = new Disco();

        string sql;
        DataTable dt;

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal prinipal = new Principal();
            prinipal.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sql = "SELECT * FROM Banda WHERE Cod_banda = '" + textBox1.Text + "'";
            dt = conexion.consultar(sql, "Banda");
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Codigo ya registrado");
            }
            else
            {
                disco.codigo = textBox1.Text;
                disco.nombre_banda = textBox2.Text;
                disco.precio = Convert.ToInt32(textBox3.Text);
                disco.estado = comboBox2.Text;

                if (comboBox1.SelectedItem.ToString() == "01 - Reggaeton")
                {
                    disco.codigo_genero = "01";
                }
                else if (comboBox1.SelectedItem.ToString() == "02 - Rock")
                {
                    disco.codigo_genero = "02";
                }
                else if (comboBox1.SelectedItem.ToString() == "03 - Cumbia")
                {
                    disco.codigo_genero = "03";
                }
                else
                {
                    disco.codigo_genero = "04";
                }

                conexion.Registrar_Disco(disco);
                Limpiar_campos();
                Cargar_dgv();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disco.codigo = textBox1.Text;
            disco.nombre_banda = textBox2.Text;
            disco.precio = Convert.ToInt32(textBox3.Text);
            disco.estado = comboBox2.Text;

            if (comboBox1.SelectedItem.ToString() == "01 - Reggaeton")
            {
                disco.codigo_genero = "01";
            }
            else if (comboBox1.SelectedItem.ToString() == "02 - Rock")
            {
                disco.codigo_genero = "02";
            }
            else if (comboBox1.SelectedItem.ToString() == "03 - Cumbia")
            {
                disco.codigo_genero = "03";
            }
            else
            {
                disco.codigo_genero = "04";
            }

            if (conexion.Modificar_disco(disco))
            {
                MessageBox.Show("Disco actualizado");
                Cargar_dgv();
                Limpiar_campos();
            }
            else
                MessageBox.Show("Error");

        }

        private void Cargar_dgv()
        {
            sql = "SELECT Nom_banda, Precio, Cod_banda, Estado, Cod_genero FROM Banda";
            dt = conexion.consultar(sql, "Banda");
            dataGridView1.DataSource = dt;
        }

        private void Limpiar_campos()
        {
            textBox1.Text = "";
            textBox1.Enabled = true;
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void InMo_Load(object sender, EventArgs e)
        {
            Cargar_dgv();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 5].Value.ToString();

            textBox1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
