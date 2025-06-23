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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            btnRegistrar = new Button();
            cboGenero = new ComboBox();
            cboCategoria = new ComboBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            btnSeleccionar = new DataGridViewButtonColumn();
            Clave = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            NroDocumento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Clave, EstadoValor, NroDocumento, NombreCompleto, Telefono, Genero, CategoriaCliente });
            dataGridView1.Location = new Point(470, 44);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(680, 371);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
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
            // txtId
            // 
            txtId.Location = new Point(391, 15);
            txtId.Name = "txtId";
            txtId.Size = new Size(37, 23);
            txtId.TabIndex = 14;
            txtId.Visible = false;
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
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 30;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // NroDocumento
            // 
            NroDocumento.HeaderText = "Numero Documento";
            NroDocumento.Name = "NroDocumento";
            NroDocumento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 180;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // CategoriaCliente
            // 
            CategoriaCliente.HeaderText = "Categoria";
            CategoriaCliente.Name = "CategoriaCliente";
            CategoriaCliente.ReadOnly = true;
            // 
            // MantenedorCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 542);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(cboCategoria);
            Controls.Add(cboGenero);
            Controls.Add(btnRegistrar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MantenedorCliente";
            Text = "Mantendor Cliente";
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
        private DataGridView dataGridView1;
        private Button btnRegistrar;
        private ComboBox cboGenero;
        private ComboBox cboCategoria;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtId;
        private Label label5;
        private TextBox textBox4;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn CategoriaCliente;
    }
}