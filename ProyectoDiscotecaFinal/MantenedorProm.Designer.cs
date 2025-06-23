namespace ProyectoDiscotecaFinal
{
    partial class MantenedorProm
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
            dataGridViewPromo = new DataGridView();
            NombrePromocion = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            CodigoPromocion = new DataGridViewTextBoxColumn();
            btnRegistrarProm = new Button();
            btnModificarProm = new Button();
            btnEliminarProm = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombrePromo = new TextBox();
            txtDescuentoPromo = new TextBox();
            dateTimePickerPromo = new DateTimePicker();
            label4 = new Label();
            txtCodigoPromocion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPromo).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPromo
            // 
            dataGridViewPromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPromo.Columns.AddRange(new DataGridViewColumn[] { NombrePromocion, Descuento, FechaVencimiento, CodigoPromocion });
            dataGridViewPromo.Location = new Point(412, 20);
            dataGridViewPromo.Name = "dataGridViewPromo";
            dataGridViewPromo.Size = new Size(497, 238);
            dataGridViewPromo.TabIndex = 0;
            dataGridViewPromo.CellClick += dataGridViewPromo_CellClick;
            // 
            // NombrePromocion
            // 
            NombrePromocion.HeaderText = "Nombre Promocion";
            NombrePromocion.Name = "NombrePromocion";
            NombrePromocion.Width = 130;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "Fecha Vencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            // 
            // CodigoPromocion
            // 
            CodigoPromocion.HeaderText = "CodigoPromocional";
            CodigoPromocion.Name = "CodigoPromocion";
            CodigoPromocion.Width = 120;
            // 
            // btnRegistrarProm
            // 
            btnRegistrarProm.BackColor = Color.Green;
            btnRegistrarProm.ForeColor = Color.White;
            btnRegistrarProm.Location = new Point(134, 168);
            btnRegistrarProm.Name = "btnRegistrarProm";
            btnRegistrarProm.Size = new Size(178, 26);
            btnRegistrarProm.TabIndex = 5;
            btnRegistrarProm.Text = "Registrar";
            btnRegistrarProm.UseVisualStyleBackColor = false;
            btnRegistrarProm.Click += btnRegistrarProm_Click;
            // 
            // btnModificarProm
            // 
            btnModificarProm.BackColor = Color.Blue;
            btnModificarProm.ForeColor = Color.White;
            btnModificarProm.Location = new Point(134, 200);
            btnModificarProm.Name = "btnModificarProm";
            btnModificarProm.Size = new Size(178, 26);
            btnModificarProm.TabIndex = 6;
            btnModificarProm.Text = "Modificar";
            btnModificarProm.UseVisualStyleBackColor = false;
            btnModificarProm.Click += btnModificarProm_Click;
            // 
            // btnEliminarProm
            // 
            btnEliminarProm.BackColor = Color.Red;
            btnEliminarProm.ForeColor = Color.White;
            btnEliminarProm.Location = new Point(134, 232);
            btnEliminarProm.Name = "btnEliminarProm";
            btnEliminarProm.Size = new Size(178, 26);
            btnEliminarProm.TabIndex = 7;
            btnEliminarProm.Text = "Eliminar";
            btnEliminarProm.UseVisualStyleBackColor = false;
            btnEliminarProm.Click += btnEliminarProm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 54);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre Promoción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 9;
            label2.Text = "Descuento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 120);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha Vencimiento";
            // 
            // txtNombrePromo
            // 
            txtNombrePromo.Location = new Point(167, 54);
            txtNombrePromo.Name = "txtNombrePromo";
            txtNombrePromo.Size = new Size(212, 23);
            txtNombrePromo.TabIndex = 11;
            // 
            // txtDescuentoPromo
            // 
            txtDescuentoPromo.Location = new Point(167, 84);
            txtDescuentoPromo.Name = "txtDescuentoPromo";
            txtDescuentoPromo.Size = new Size(79, 23);
            txtDescuentoPromo.TabIndex = 12;
            // 
            // dateTimePickerPromo
            // 
            dateTimePickerPromo.Location = new Point(167, 112);
            dateTimePickerPromo.Name = "dateTimePickerPromo";
            dateTimePickerPromo.Size = new Size(212, 23);
            dateTimePickerPromo.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 31);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 14;
            label4.Text = "Codigo Promocional";
            // 
            // txtCodigoPromocion
            // 
            txtCodigoPromocion.Location = new Point(167, 25);
            txtCodigoPromocion.Name = "txtCodigoPromocion";
            txtCodigoPromocion.Size = new Size(212, 23);
            txtCodigoPromocion.TabIndex = 15;
            // 
            // MantenedorProm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 284);
            Controls.Add(txtCodigoPromocion);
            Controls.Add(label4);
            Controls.Add(dateTimePickerPromo);
            Controls.Add(txtDescuentoPromo);
            Controls.Add(txtNombrePromo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminarProm);
            Controls.Add(btnModificarProm);
            Controls.Add(btnRegistrarProm);
            Controls.Add(dataGridViewPromo);
            Name = "MantenedorProm";
            Text = "MantenedorProm";
            Load += MantenedorProm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPromo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPromo;
        private Button btnRegistrarProm;
        private Button btnModificarProm;
        private Button btnEliminarProm;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombrePromo;
        private TextBox txtDescuentoPromo;
        private DateTimePicker dateTimePickerPromo;
        private DataGridViewTextBoxColumn NombrePromocion;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private DataGridViewTextBoxColumn CodigoPromocion;
        private Label label4;
        private TextBox txtCodigoPromocion;
    }
}