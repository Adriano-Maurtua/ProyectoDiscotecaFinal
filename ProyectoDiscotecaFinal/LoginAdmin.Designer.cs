namespace ProyectoDiscotecaFinal
{
    partial class LoginAdmin
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnIncioAdmin = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 122);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(87, 18);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 4;
            label3.Text = "INICIO DE SESION";
            // 
            // btnIncioAdmin
            // 
            btnIncioAdmin.BackColor = SystemColors.ButtonHighlight;
            btnIncioAdmin.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnIncioAdmin.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnIncioAdmin.FlatStyle = FlatStyle.Flat;
            btnIncioAdmin.Location = new Point(104, 171);
            btnIncioAdmin.Name = "btnIncioAdmin";
            btnIncioAdmin.Size = new Size(104, 24);
            btnIncioAdmin.TabIndex = 5;
            btnIncioAdmin.Text = "CONTINUAR";
            btnIncioAdmin.UseVisualStyleBackColor = false;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(329, 222);
            Controls.Add(btnIncioAdmin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LoginAdmin";
            Text = "LoginAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIncioAdmin;
    }
}