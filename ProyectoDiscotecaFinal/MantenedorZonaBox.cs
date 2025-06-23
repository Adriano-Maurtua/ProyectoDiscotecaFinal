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
    public partial class MantenedorZonaBox : Form
    {
        private string rutaArchivoZona = @"D:\ProyectoDiscoteca\ProyectoDiscotecaFinal\zonas.txt";
        public MantenedorZonaBox()
        {
            InitializeComponent();
            if (!File.Exists(rutaArchivoZona))
            {
                File.Create(rutaArchivoZona).Close();
            }
        }

        private void MantenedorZonaBox_Load(object sender, EventArgs e)
        {
            CargarZonasDesdeArchivo();
        }
        private void CargarZonasDesdeArchivo()
        {
            if (!File.Exists(rutaArchivoZona))
                return;

            dataGridViewZona.Rows.Clear();

            string[] lineas = File.ReadAllLines(rutaArchivoZona);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length == 2)
                {
                    string nombre = datos[0];
                    string precio = datos[1];

                    dataGridViewZona.Rows.Add(nombre, precio);
                }
            }
        }

        private void btnRegistrarZona_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreZona.Text.Trim();
            string precio = txtPrecioZona.Text.Trim();

            if (nombre == "" || precio == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            dataGridViewZona.Rows.Add(nombre, precio);

            using (StreamWriter sw = new StreamWriter(rutaArchivoZona, true))
            {
                sw.WriteLine($"{nombre}|{precio}");
            }

            txtNombreZona.Clear();
            txtPrecioZona.Clear();
        }

        private void btnModificarZona_Click(object sender, EventArgs e)
        {
            if (dataGridViewZona.CurrentRow == null)
                return;

            int fila = dataGridViewZona.CurrentRow.Index;

            dataGridViewZona.Rows[fila].Cells[0].Value = txtNombreZona.Text.Trim();
            dataGridViewZona.Rows[fila].Cells[1].Value = txtPrecioZona.Text.Trim();

            // Actualizar el archivo
            using (StreamWriter sw = new StreamWriter(rutaArchivoZona))
            {
                foreach (DataGridViewRow row in dataGridViewZona.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        sw.WriteLine($"{row.Cells[0].Value}|{row.Cells[1].Value}");
                    }
                }
            }

            MessageBox.Show("Zona modificada correctamente.");
        }

        private void btnEliminarZona_Click(object sender, EventArgs e)
        {
            if (dataGridViewZona.CurrentRow == null)
                return;

            int fila = dataGridViewZona.CurrentRow.Index;
            dataGridViewZona.Rows.RemoveAt(fila);

            using (StreamWriter sw = new StreamWriter(rutaArchivoZona))
            {
                foreach (DataGridViewRow row in dataGridViewZona.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        sw.WriteLine($"{row.Cells[0].Value}|{row.Cells[1].Value}");
                    }
                }
            }

            MessageBox.Show("Zona eliminada correctamente.");
        }
        private void dataGridViewZona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewZona.Rows[e.RowIndex].Cells[0].Value != null)
            {
                txtNombreZona.Text = dataGridViewZona.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPrecioZona.Text = dataGridViewZona.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
