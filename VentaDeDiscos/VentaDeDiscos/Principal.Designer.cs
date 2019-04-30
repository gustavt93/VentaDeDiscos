namespace VentaDeDiscos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vendedor = new System.Windows.Forms.Label();
            this.disco = new System.Windows.Forms.Label();
            this.discosDataSet = new VentaDeDiscos.DiscosDataSet();
            this.bandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandaTableAdapter = new VentaDeDiscos.DiscosDataSetTableAdapters.BandaTableAdapter();
            this.codbandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codgeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(882, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarModificarToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codbandaDataGridViewTextBoxColumn,
            this.codgeneroDataGridViewTextBoxColumn,
            this.nombandaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bandaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(293, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(369, 237);
            this.dataGridView2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informacion de disco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(671, 184);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(142, 22);
            this.dni.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(671, 212);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(142, 22);
            this.nombre.TabIndex = 10;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(671, 240);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(142, 22);
            this.apellido.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Vender";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // vendedor
            // 
            this.vendedor.AutoSize = true;
            this.vendedor.Location = new System.Drawing.Point(716, 79);
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(46, 17);
            this.vendedor.TabIndex = 14;
            this.vendedor.Text = "label6";
            // 
            // disco
            // 
            this.disco.AutoSize = true;
            this.disco.Location = new System.Drawing.Point(716, 123);
            this.disco.Name = "disco";
            this.disco.Size = new System.Drawing.Size(46, 17);
            this.disco.TabIndex = 15;
            this.disco.Text = "label6";
            // 
            // discosDataSet
            // 
            this.discosDataSet.DataSetName = "DiscosDataSet";
            this.discosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandaBindingSource
            // 
            this.bandaBindingSource.DataMember = "Banda";
            this.bandaBindingSource.DataSource = this.discosDataSet;
            // 
            // bandaTableAdapter
            // 
            this.bandaTableAdapter.ClearBeforeFill = true;
            // 
            // codbandaDataGridViewTextBoxColumn
            // 
            this.codbandaDataGridViewTextBoxColumn.DataPropertyName = "Cod_banda";
            this.codbandaDataGridViewTextBoxColumn.HeaderText = "Cod_banda";
            this.codbandaDataGridViewTextBoxColumn.Name = "codbandaDataGridViewTextBoxColumn";
            // 
            // codgeneroDataGridViewTextBoxColumn
            // 
            this.codgeneroDataGridViewTextBoxColumn.DataPropertyName = "Cod_genero";
            this.codgeneroDataGridViewTextBoxColumn.HeaderText = "Cod_genero";
            this.codgeneroDataGridViewTextBoxColumn.Name = "codgeneroDataGridViewTextBoxColumn";
            // 
            // nombandaDataGridViewTextBoxColumn
            // 
            this.nombandaDataGridViewTextBoxColumn.DataPropertyName = "Nom_banda";
            this.nombandaDataGridViewTextBoxColumn.HeaderText = "Nom_banda";
            this.nombandaDataGridViewTextBoxColumn.Name = "nombandaDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // insertarModificarToolStripMenuItem
            // 
            this.insertarModificarToolStripMenuItem.Name = "insertarModificarToolStripMenuItem";
            this.insertarModificarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.insertarModificarToolStripMenuItem.Text = "Insertar/Modificar";
            this.insertarModificarToolStripMenuItem.Click += new System.EventHandler(this.InsertarModificarToolStripMenuItem_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(857, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 309);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.disco);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label vendedor;
        private System.Windows.Forms.Label disco;
        private DiscosDataSet discosDataSet;
        private System.Windows.Forms.BindingSource bandaBindingSource;
        private DiscosDataSetTableAdapters.BandaTableAdapter bandaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codbandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codgeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem insertarModificarToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}