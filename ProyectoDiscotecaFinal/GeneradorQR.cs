using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscotecaFinal
{
    public partial class GeneradorQR : Form
    {
        private string nroComprobante;
        public GeneradorQR()
        {
            InitializeComponent();
            string comprobanteValido = "C12345678";
            nroComprobante = comprobanteValido;
        }

        private void GeneradorQR_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nroComprobante))
            {
                MessageBox.Show("No se ha proporcionado ningún número de comprobante.", "Error");
                return;
            }
            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData qrData = qrGen.CreateQrCode(nroComprobante, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);

            Bitmap qrImage = qrCode.GetGraphic(10);
            pictureBoxQR.Image = qrImage;
        }
    }
}
