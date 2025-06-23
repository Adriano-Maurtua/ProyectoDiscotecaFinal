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
        public GeneradorQR()
        {
            InitializeComponent();
            txtDatosQR.Text = datosReserva;
        }

        private void GeneradorQR_Load(object sender, EventArgs e)
        {
            string datos = "Nombre: Juan Pérez\nZona: A\nBox: 2\nFecha: 25/06/2025\nComprobante: 123456";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(datos, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(5);
            pictureBoxQR.Image = qrCodeImage;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string contenido = txtDatosQR.Text;

            if (!string.IsNullOrWhiteSpace(contenido))
            {
                QRCodeGenerator qrGenerador = new QRCodeGenerator();
                QRCodeData qrDatos = qrGenerador.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCodigo = new QRCode(qrDatos);
                Bitmap qrImagen = qrCodigo.GetGraphic(10);
                pictureBoxQR.Image = qrImagen;
            }
            else
            {
                MessageBox.Show("No hay datos para generar el código QR.");
            }
        }
    }
}
