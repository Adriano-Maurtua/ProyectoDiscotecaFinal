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
    public partial class ReprogramarReserva : Form
    {
        private string rutaFechasOcupadas = @"D:\ProyectoDiscoteca\ProyectoDiscotecaFinal\fechas_ocupadas.txt";
        private string fechaSeleccionada = null!;
        private string zonaSeleccionada = "Zona 1"; 
        private string boxSeleccionado = "";

        public ReprogramarReserva()
        {
            InitializeComponent();
        }

        private void btnVerificarFecha_Click(object sender, EventArgs e)
        {
            fechaSeleccionada = monthCalendarReprogramar.SelectionStart.ToString("dd/MM/yyyy");

            if (!File.Exists(rutaFechasOcupadas))
                File.Create(rutaFechasOcupadas).Close();

            string[] fechasOcupadas = File.ReadAllLines(rutaFechasOcupadas);

            if (fechasOcupadas.Contains(fechaSeleccionada))
            {
                MessageBox.Show("No hay disponibilidad en esta fecha. Por favor, elige otra.", "Fecha Ocupada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fechaSeleccionada = null;
            }
            else
            {
                MessageBox.Show("¡Fecha disponible! Ahora puedes seleccionar tu box.", "Fecha Libre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para todos los botones de box
        private void btnBox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fechaSeleccionada))
            {
                MessageBox.Show("Primero debes verificar una fecha disponible antes de seleccionar un box.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Button botonSeleccionado = sender as Button;

            if (botonSeleccionado != null)
            {
                LimpiarSeleccionDeBoxes();
                botonSeleccionado.BackColor = Color.Yellow;

                string nombreBox = botonSeleccionado.Name.Replace("btnBox", "Box ");
                MessageBox.Show($"Seleccionaste el {nombreBox} para el {fechaSeleccionada}");
            }
        }

        private void LimpiarSeleccionDeBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button boton && boton.Name.StartsWith("btnBox"))
                {
                    boton.BackColor = Color.Green;
                }
            }
        }

        // Conecta todos los btnBox al mismo método
        private void ReprogramarReserva_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button boton && boton.Name.StartsWith("btnBox"))
                {
                    boton.BackColor = Color.Green;
                    boton.Click += btnBox_Click;
                }
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string comprobanteIngresado = txtNroComprobante.Text.Trim();

            // Número de comprobante correcto de ejemplo
            string comprobanteValido = "C12345678";

            if (comprobanteIngresado == comprobanteValido)
            {
                MessageBox.Show("✅ Número de comprobante válido.", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Número de comprobante incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string nro = txtNroComprobante.Text.Trim();

            if (string.IsNullOrEmpty(nro))
            {
                MessageBox.Show("Ingresa un número de comprobante primero.");
                return;
            }

            GeneradorQR formQR = new GeneradorQR();
            formQR.Show();
            this.Hide(); 
        }
    }
}
