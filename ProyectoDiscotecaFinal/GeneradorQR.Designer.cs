namespace ProyectoDiscotecaFinal
{
    partial class GeneradorQR
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
            pictureBoxQR = new PictureBox();
            txtDatosQR = new TextBox();
            btnGenerar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.Location = new Point(72, 35);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(218, 232);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQR.TabIndex = 0;
            pictureBoxQR.TabStop = false;
            // 
            // txtDatosQR
            // 
            txtDatosQR.Location = new Point(32, 287);
            txtDatosQR.Multiline = true;
            txtDatosQR.Name = "txtDatosQR";
            txtDatosQR.ReadOnly = true;
            txtDatosQR.Size = new Size(300, 100);
            txtDatosQR.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(147, 402);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // GeneradorQR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(361, 450);
            Controls.Add(btnGenerar);
            Controls.Add(txtDatosQR);
            Controls.Add(pictureBoxQR);
            Name = "GeneradorQR";
            Text = "GeneradorQR";
            Load += GeneradorQR_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxQR;
        private TextBox txtDatosQR;
        private Button btnGenerar;
    }
}