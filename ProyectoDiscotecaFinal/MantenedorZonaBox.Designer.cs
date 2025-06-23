namespace ProyectoDiscotecaFinal
{
    partial class MantenedorZonaBox
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
            dataGridViewZona = new DataGridView();
            NOMBREZONA = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtNombreZona = new TextBox();
            txtPrecioZona = new TextBox();
            btnEliminarZona = new Button();
            btnModificarZona = new Button();
            btnRegistrarZona = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZona).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewZona
            // 
            dataGridViewZona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZona.Columns.AddRange(new DataGridViewColumn[] { NOMBREZONA, Precio });
            dataGridViewZona.Location = new Point(370, 25);
            dataGridViewZona.Name = "dataGridViewZona";
            dataGridViewZona.Size = new Size(242, 249);
            dataGridViewZona.TabIndex = 0;
            dataGridViewZona.CellClick += dataGridViewZona_CellClick;
            // 
            // NOMBREZONA
            // 
            NOMBREZONA.HeaderText = "Nombre";
            NOMBREZONA.Name = "NOMBREZONA";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Zona:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // txtNombreZona
            // 
            txtNombreZona.Location = new Point(152, 45);
            txtNombreZona.Name = "txtNombreZona";
            txtNombreZona.Size = new Size(148, 23);
            txtNombreZona.TabIndex = 3;
            // 
            // txtPrecioZona
            // 
            txtPrecioZona.Location = new Point(152, 79);
            txtPrecioZona.Name = "txtPrecioZona";
            txtPrecioZona.Size = new Size(148, 23);
            txtPrecioZona.TabIndex = 4;
            // 
            // btnEliminarZona
            // 
            btnEliminarZona.BackColor = Color.Red;
            btnEliminarZona.ForeColor = Color.White;
            btnEliminarZona.Location = new Point(79, 198);
            btnEliminarZona.Name = "btnEliminarZona";
            btnEliminarZona.Size = new Size(178, 26);
            btnEliminarZona.TabIndex = 10;
            btnEliminarZona.Text = "Eliminar";
            btnEliminarZona.UseVisualStyleBackColor = false;
            btnEliminarZona.Click += btnEliminarZona_Click;
            // 
            // btnModificarZona
            // 
            btnModificarZona.BackColor = Color.Blue;
            btnModificarZona.ForeColor = Color.White;
            btnModificarZona.Location = new Point(79, 166);
            btnModificarZona.Name = "btnModificarZona";
            btnModificarZona.Size = new Size(178, 26);
            btnModificarZona.TabIndex = 9;
            btnModificarZona.Text = "Modificar";
            btnModificarZona.UseVisualStyleBackColor = false;
            btnModificarZona.Click += btnModificarZona_Click;
            // 
            // btnRegistrarZona
            // 
            btnRegistrarZona.BackColor = Color.Green;
            btnRegistrarZona.ForeColor = Color.White;
            btnRegistrarZona.Location = new Point(79, 134);
            btnRegistrarZona.Name = "btnRegistrarZona";
            btnRegistrarZona.Size = new Size(178, 26);
            btnRegistrarZona.TabIndex = 8;
            btnRegistrarZona.Text = "Registrar";
            btnRegistrarZona.UseVisualStyleBackColor = false;
            btnRegistrarZona.Click += btnRegistrarZona_Click;
            // 
            // MantenedorZonaBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(644, 282);
            Controls.Add(btnEliminarZona);
            Controls.Add(btnModificarZona);
            Controls.Add(btnRegistrarZona);
            Controls.Add(txtPrecioZona);
            Controls.Add(txtNombreZona);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewZona);
            Name = "MantenedorZonaBox";
            Text = "MantenedorZonaBox";
            Load += MantenedorZonaBox_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewZona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewZona;
        private DataGridViewTextBoxColumn NOMBREZONA;
        private DataGridViewTextBoxColumn Precio;
        private Label label1;
        private Label label2;
        private TextBox txtNombreZona;
        private TextBox txtPrecioZona;
        private Button btnEliminarZona;
        private Button btnModificarZona;
        private Button btnRegistrarZona;
    }
}