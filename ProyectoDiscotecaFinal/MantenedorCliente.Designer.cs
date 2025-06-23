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
            txtDocumento = new TextBox();
            txtNombreCompleto = new TextBox();
            btnRegistrar = new Button();
            cboGenero = new ComboBox();
            cboCategoria = new ComboBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            label5 = new Label();
            txtTelefono = new TextBox();
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
            // txtDocumento
            // 
            txtDocumento.Location = new Point(180, 44);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(248, 23);
            txtDocumento.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(180, 85);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(248, 23);
            txtNombreCompleto.TabIndex = 5;
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
            btnRegistrar.Click += btnRegistrar_Click;
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
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(96, 339);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(178, 26);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Blue;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(96, 310);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(178, 26);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
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
            // txtTelefono
            // 
            txtTelefono.Location = new Point(180, 126);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(248, 23);
            txtTelefono.TabIndex = 16;
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
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(cboCategoria);
            Controls.Add(cboGenero);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MantenedorCliente";
            Text = "Mantenedor Cliente";
            Load += MantenedorCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDocumento;
        private TextBox txtNombreCompleto;
        private Button btnRegistrar;
        private ComboBox cboGenero;
        private ComboBox cboCategoria;
        private Button btnEliminar;
        private Button btnModificar;
        private Label label5;
        private TextBox txtTelefono;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NroDocumento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn CategoriaCliente;
    }
}