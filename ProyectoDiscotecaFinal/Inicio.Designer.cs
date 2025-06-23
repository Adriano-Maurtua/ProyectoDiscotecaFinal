namespace ProyectoDiscotecaFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdmin = new Button();
            btnVendedor = new Button();
            label1 = new Label();
            label2 = new Label();
            domainUpDown1 = new DomainUpDown();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ButtonHighlight;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdmin.Location = new Point(95, 111);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(129, 29);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "ADMINISTRADOR";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnVendedor
            // 
            btnVendedor.BackColor = SystemColors.ButtonHighlight;
            btnVendedor.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnVendedor.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnVendedor.FlatStyle = FlatStyle.Flat;
            btnVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVendedor.Location = new Point(95, 158);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(129, 29);
            btnVendedor.TabIndex = 1;
            btnVendedor.Text = "VENDEDOR";
            btnVendedor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(90, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(82, 61);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 3;
            label2.Text = "Selecciona tu cargo:";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(147, 212);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 4;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(319, 267);
            Controls.Add(domainUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVendedor);
            Controls.Add(btnAdmin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmin;
        private Button btnVendedor;
        private Label label1;
        private Label label2;
        private DomainUpDown domainUpDown1;
    }
}
