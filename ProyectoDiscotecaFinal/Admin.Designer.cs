namespace ProyectoDiscotecaFinal
{
    partial class Admin
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
            btnMantenedorCliente = new Button();
            btnReprogramar = new Button();
            btnMantenedorPromocion = new Button();
            label1 = new Label();
            btnMantenedorZona = new Button();
            SuspendLayout();
            // 
            // btnMantenedorCliente
            // 
            btnMantenedorCliente.BackColor = Color.White;
            btnMantenedorCliente.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnMantenedorCliente.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnMantenedorCliente.FlatStyle = FlatStyle.Flat;
            btnMantenedorCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMantenedorCliente.ForeColor = Color.Black;
            btnMantenedorCliente.Location = new Point(12, 86);
            btnMantenedorCliente.Name = "btnMantenedorCliente";
            btnMantenedorCliente.Size = new Size(137, 56);
            btnMantenedorCliente.TabIndex = 0;
            btnMantenedorCliente.Text = "Mantenedor Cliente";
            btnMantenedorCliente.UseVisualStyleBackColor = false;
            btnMantenedorCliente.Click += btnMantenedorCliente_Click;
            // 
            // btnReprogramar
            // 
            btnReprogramar.BackColor = Color.White;
            btnReprogramar.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnReprogramar.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnReprogramar.FlatStyle = FlatStyle.Flat;
            btnReprogramar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReprogramar.ForeColor = Color.Black;
            btnReprogramar.Location = new Point(171, 86);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(137, 56);
            btnReprogramar.TabIndex = 1;
            btnReprogramar.Text = "Reprogramar Reserva";
            btnReprogramar.UseVisualStyleBackColor = false;
            // 
            // btnMantenedorPromocion
            // 
            btnMantenedorPromocion.BackColor = Color.White;
            btnMantenedorPromocion.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnMantenedorPromocion.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnMantenedorPromocion.FlatStyle = FlatStyle.Flat;
            btnMantenedorPromocion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMantenedorPromocion.ForeColor = Color.Black;
            btnMantenedorPromocion.Location = new Point(331, 86);
            btnMantenedorPromocion.Name = "btnMantenedorPromocion";
            btnMantenedorPromocion.Size = new Size(137, 56);
            btnMantenedorPromocion.TabIndex = 2;
            btnMantenedorPromocion.Text = "Mantenedor Promocion";
            btnMantenedorPromocion.UseVisualStyleBackColor = false;
            btnMantenedorPromocion.Click += btnMantenedorPromocion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(221, 21);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 3;
            label1.Text = "ADMINISTRADOR";
            // 
            // btnMantenedorZona
            // 
            btnMantenedorZona.BackColor = Color.White;
            btnMantenedorZona.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnMantenedorZona.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnMantenedorZona.FlatStyle = FlatStyle.Flat;
            btnMantenedorZona.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMantenedorZona.ForeColor = Color.Black;
            btnMantenedorZona.Location = new Point(498, 86);
            btnMantenedorZona.Name = "btnMantenedorZona";
            btnMantenedorZona.Size = new Size(137, 56);
            btnMantenedorZona.TabIndex = 4;
            btnMantenedorZona.Text = "Mantenedor Zona Box";
            btnMantenedorZona.UseVisualStyleBackColor = false;
            btnMantenedorZona.Click += btnMantenedorZona_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(669, 195);
            Controls.Add(btnMantenedorZona);
            Controls.Add(label1);
            Controls.Add(btnMantenedorPromocion);
            Controls.Add(btnReprogramar);
            Controls.Add(btnMantenedorCliente);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMantenedorCliente;
        private Button btnReprogramar;
        private Button btnMantenedorPromocion;
        private Label label1;
        private Button btnMantenedorZona;
    }
}