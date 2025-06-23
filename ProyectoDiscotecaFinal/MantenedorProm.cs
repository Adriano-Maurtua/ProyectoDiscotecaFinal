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
    public partial class MantenedorProm : Form
    {
        private string rutaArchivoPromo = @"D:\ProyectoDiscoteca\ProyectoDiscotecaFinal\promociones.txt";
        public MantenedorProm()
        {
            InitializeComponent();
            btnRegistrarProm.Click += btnRegistrarProm_Click;
            if (!File.Exists(rutaArchivoPromo))
            {
                File.Create(rutaArchivoPromo).Close();
            }
        }

        private void MantenedorProm_Load(object sender, EventArgs e)
        {
            CargarPromocionesDesdeArchivo();
        }
        private void CargarPromocionesDesdeArchivo()
        {
            if (!File.Exists(rutaArchivoPromo))
                return;

            dataGridViewPromo.Rows.Clear(); // Limpiar DGV

            string[] lineas = File.ReadAllLines(rutaArchivoPromo);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length == 4)
                {
                    string codigo = datos[0];
                    string nombre = datos[1];
                    string descuento = datos[2];
                    string fechaVenc = datos[3];

                    dataGridViewPromo.Rows.Add(codigo, nombre, descuento, fechaVenc);
                }
            }
        }

        private void btnRegistrarProm_Click(object sender, EventArgs e)
        {
            {
                string codigo = txtCodigoPromocion.Text.Trim();
                string nombre = txtNombrePromo.Text.Trim();
                string porcentaje = txtDescuentoPromo.Text.Trim();
                string fecha = dateTimePickerPromo.Value.ToString("dd/MM/yyyy");

                if (codigo == "" || nombre == "" || porcentaje == "")
                {
                    MessageBox.Show("Por favor completa todos los campos.");
                    return;
                }

                // Agregar al DataGridView
                dataGridViewPromo.Rows.Add(codigo, nombre, porcentaje, fecha);

                // Guardar en el archivo .txt
                using (StreamWriter sw = new StreamWriter(rutaArchivoPromo, true)) // append
                {
                    sw.WriteLine($"{codigo}|{nombre}|{porcentaje}|{fecha}");
                }

                // Limpiar campos
                txtCodigoPromocion.Clear();
                txtNombrePromo.Clear();
                txtDescuentoPromo.Clear();
                dateTimePickerPromo.Value = DateTime.Today;

                MessageBox.Show("Promoción registrada correctamente.");
            }
        }
        private void btnModificarProm_Click(object sender, EventArgs e)
        {
            if (dataGridViewPromo.CurrentRow == null || dataGridViewPromo.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona una promoción para modificar.");
                return;
            }

            int fila = dataGridViewPromo.CurrentRow.Index;

            // Obtener nuevos valores desde el formulario
            string codigo = txtCodigoPromocion.Text.Trim();
            string nombre = txtNombrePromo.Text.Trim();
            string descuento = txtDescuentoPromo.Text.Trim();
            string fecha = dateTimePickerPromo.Value.ToString("dd/MM/yyyy");

            // Validación básica
            if (codigo == "" || nombre == "" || descuento == "")
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            if (!decimal.TryParse(descuento, out _))
            {
                MessageBox.Show("El descuento debe ser un número.");
                return;
            }

            // Actualizar el DGV
            dataGridViewPromo.Rows[fila].Cells[0].Value = codigo;
            dataGridViewPromo.Rows[fila].Cells[1].Value = nombre;
            dataGridViewPromo.Rows[fila].Cells[2].Value = descuento;
            dataGridViewPromo.Rows[fila].Cells[3].Value = fecha;

            // Reescribir el archivo con los nuevos datos
            using (StreamWriter sw = new StreamWriter(rutaArchivoPromo))
            {
                foreach (DataGridViewRow row in dataGridViewPromo.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string linea = string.Join("|", new string[]
                        {
                    row.Cells[0].Value.ToString(), // Código
                    row.Cells[1].Value.ToString(), // Nombre
                    row.Cells[2].Value.ToString(), // Descuento
                    row.Cells[3].Value.ToString()  // Fecha
                        });

                        sw.WriteLine(linea);
                    }
                }
            }

            MessageBox.Show("Promoción modificada correctamente.");
        }
        private void dataGridViewPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewPromo.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow fila = dataGridViewPromo.Rows[e.RowIndex];

                txtCodigoPromocion.Text = fila.Cells[0].Value.ToString();
                txtNombrePromo.Text = fila.Cells[1].Value.ToString();
                txtDescuentoPromo.Text = fila.Cells[2].Value.ToString();

                // Intentar convertir la fecha al tipo DateTime
                DateTime fecha;
                if (DateTime.TryParseExact(fila.Cells[3].Value.ToString(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fecha))
                {
                    dateTimePickerPromo.Value = fecha;
                }
                else
                {
                    dateTimePickerPromo.Value = DateTime.Today;
                }
            }
        }

        private void btnEliminarProm_Click(object sender, EventArgs e)
        {
            if (dataGridViewPromo.CurrentRow == null || dataGridViewPromo.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.");
                return;
            }

            int fila = dataGridViewPromo.CurrentRow.Index;

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de eliminar esta promoción?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                // Eliminar del DataGridView
                dataGridViewPromo.Rows.RemoveAt(fila);

                // Reescribir el archivo con las promociones restantes
                using (StreamWriter sw = new StreamWriter(rutaArchivoPromo))
                {
                    foreach (DataGridViewRow row in dataGridViewPromo.Rows)
                    {
                        if (row.Cells[0].Value != null) // evitar filas vacías
                        {
                            string linea = string.Join("|", new string[]
                            {
                        row.Cells[0].Value.ToString(),  // Código
                        row.Cells[1].Value.ToString(),  // Nombre
                        row.Cells[2].Value.ToString(),  // Porcentaje
                        row.Cells[3].Value.ToString()   // Fecha
                            });

                            sw.WriteLine(linea);
                        }
                    }
                }

                MessageBox.Show("Promoción eliminada correctamente.");
            }
        }
    }


}
