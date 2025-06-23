namespace ProyectoDiscotecaFinal
{
    partial class MantenedorCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnRegistrar = new Button();
            cboGenero = new ComboBox();
            cboCategoria = new ComboBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            NroDocumento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            CategoriaCliente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Nro Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 85);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 167);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Genero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 208);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 23);
            textBox2.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(0, 192, 0);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(96, 281);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(178, 26);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cboGenero.Location = new Point(180, 167);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 23);
            cboGenero.TabIndex = 10;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "VIP", "Normal" });
            cboCategoria.Location = new Point(180, 205);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Red;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(96, 339);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(178, 26);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Eliminar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Blue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(96, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 26);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Modificar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 126);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 15;
            label5.Text = "Telefono";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(180, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 23);
            textBox4.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NroDocumento, Telefono, NombreCompleto, Genero, CategoriaCliente });
            dataGridView1.Location = new Point(519, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(691, 292);
            dataGridView1.TabIndex = 30;
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Nro Documento";
            NroDocumento.Name = "NroDocumento";
            NroDocumento.Width = 130;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 110;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Width = 190;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            // 
            // CategoriaCliente
            // 
            CategoriaCliente.HeaderText = "Categoria";
            CategoriaCliente.Name = "CategoriaCliente";
            CategoriaCliente.Width = 110;
            // 
            // MantenedorCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1235, 400);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(cboCategoria);
            Controls.Add(cboGenero);
            Controls.Add(btnRegistrar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MantenedorCliente";
            Text = "Mantenedor Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRegistrar;
        private ComboBox cboGenero;
        private ComboBox cboCategoria;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label5;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn CategoriaCliente;
    }
}