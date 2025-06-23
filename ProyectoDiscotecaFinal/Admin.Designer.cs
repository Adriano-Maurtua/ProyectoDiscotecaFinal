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
            btnPromocion = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMantenedorCliente
            // 
            btnMantenedorCliente.BackColor = Color.Black;
            btnMantenedorCliente.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnMantenedorCliente.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnMantenedorCliente.FlatStyle = FlatStyle.Flat;
            btnMantenedorCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMantenedorCliente.ForeColor = Color.White;
            btnMantenedorCliente.Location = new Point(12, 86);
            btnMantenedorCliente.Name = "btnMantenedorCliente";
            btnMantenedorCliente.Size = new Size(137, 56);
            btnMantenedorCliente.TabIndex = 0;
            btnMantenedorCliente.Text = "Mantenedor Cliente";
            btnMantenedorCliente.UseVisualStyleBackColor = false;
            // 
            // btnReprogramar
            // 
            btnReprogramar.BackColor = Color.Black;
            btnReprogramar.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnReprogramar.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnReprogramar.FlatStyle = FlatStyle.Flat;
            btnReprogramar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReprogramar.ForeColor = Color.White;
            btnReprogramar.Location = new Point(171, 86);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(137, 56);
            btnReprogramar.TabIndex = 1;
            btnReprogramar.Text = "Reprogramar Reserva";
            btnReprogramar.UseVisualStyleBackColor = false;
            // 
            // btnPromocion
            // 
            btnPromocion.BackColor = Color.Black;
            btnPromocion.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnPromocion.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnPromocion.FlatStyle = FlatStyle.Flat;
            btnPromocion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPromocion.ForeColor = Color.White;
            btnPromocion.Location = new Point(331, 86);
            btnPromocion.Name = "btnPromocion";
            btnPromocion.Size = new Size(137, 56);
            btnPromocion.TabIndex = 2;
            btnPromocion.Text = "Mantenedor Promocion";
            btnPromocion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 21);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 3;
            label1.Text = "ADMINISTRADOR";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 195);
            Controls.Add(label1);
            Controls.Add(btnPromocion);
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
        private Button btnPromocion;
        private Label label1;
    }
}