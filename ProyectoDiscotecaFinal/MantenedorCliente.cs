using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscotecaFinal
{
    public partial class MantenedorCliente : Form
    {
        private string rutaArchivo = @"D:\ProyectoDiscoteca\ProyectoDiscotecaFinal\clientes.txt";

        public MantenedorCliente()
        {
            InitializeComponent();

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }

            // Asociar el evento CellClick al método
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Crear el archivo si no existe
            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close(); // Se cierra inmediatamente para liberar el archivo
            }
        }

        private void MantenedorCliente_Load(object sender, EventArgs e)
        {
            CargarClientesDesdeArchivo();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Obtener los datos del formulario
            string documento = txtDocumento.Text.Trim();
            string nombre = txtNombreCompleto.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string genero = cboGenero.Text;
            string categoria = cboCategoria.Text;

            // 2. Validar campos (opcional)
            if (documento == "" || nombre == "" || telefono == "" || genero == "" || categoria == "")
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            // 3. Crear objeto cliente
            Cliente nuevoCliente = new Cliente
            {
                Documento = documento,
                NombreCompleto = nombre,
                Telefono = telefono,
                Genero = genero,
                Categoria = categoria
            };

            // 4. Guardar en archivo
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true)) // modo "append"
            {
                sw.WriteLine($"{nuevoCliente.Documento}|{nuevoCliente.Telefono}|{nuevoCliente.NombreCompleto}|{nuevoCliente.Genero}|{nuevoCliente.Categoria}");
            }

            // 5. Agregar al DataGridView (asumiendo columnas manuales)
            dataGridView1.Rows.Add(
                nuevoCliente.Documento,
                nuevoCliente.Telefono,
                nuevoCliente.NombreCompleto,
                nuevoCliente.Genero,
                nuevoCliente.Categoria
            );

            LimpiarCampos();


        }
        private void CargarClientesDesdeArchivo()
        {
            if (!File.Exists(rutaArchivo))
                return;

            dataGridView1.Rows.Clear(); // Limpiar el DataGridView

            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');
                if (datos.Length == 5)
                {
                    string documento = datos[0];
                    string telefono = datos[1];
                    string nombre = datos[2];
                    string genero = datos[3];
                    string categoria = datos[4];

                    dataGridView1.Rows.Add(documento, telefono, nombre, genero, categoria);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtDocumento.Text = fila.Cells[0].Value.ToString();
                txtTelefono.Text = fila.Cells[1].Value.ToString();
                txtNombreCompleto.Text = fila.Cells[2].Value.ToString();
                cboGenero.Text = fila.Cells[3].Value.ToString();
                cboCategoria.Text = fila.Cells[4].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor selecciona una fila para modificar.");
                return;
            }

            int fila = dataGridView1.CurrentRow.Index;

            // 1. Obtener los nuevos datos de los campos
            string documento = txtDocumento.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string nombre = txtNombreCompleto.Text.Trim();
            string genero = cboGenero.Text;
            string categoria = cboCategoria.Text;

            // 2. Validación
            if (documento == "" || telefono == "" || nombre == "" || genero == "" || categoria == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            // 3. Actualizar DataGridView
            dataGridView1.Rows[fila].Cells[0].Value = documento;
            dataGridView1.Rows[fila].Cells[1].Value = telefono;
            dataGridView1.Rows[fila].Cells[2].Value = nombre;
            dataGridView1.Rows[fila].Cells[3].Value = genero;
            dataGridView1.Rows[fila].Cells[4].Value = categoria;

            // 4. Reconstruir todos los datos y sobrescribir el archivo
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null) // Ignorar filas vacías
                    {
                        string linea = string.Join("|", new string[]
                        {
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString()
                        });

                        sw.WriteLine(linea);
                    }
                }
            }

            MessageBox.Show("Cliente modificado correctamente.");
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.");
                return;
            }

            int fila = dataGridView1.CurrentRow.Index;

            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(fila);

                // Reescribir el archivo sin la fila eliminada
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null) // Ignorar filas vacías
                        {
                            string linea = string.Join("|", new string[]
                            {
                        row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString()
                            });

                            sw.WriteLine(linea);
                        }
                    }
                }

                MessageBox.Show("Cliente eliminado correctamente.");
                LimpiarCampos();

            }
        }
        private void LimpiarCampos()
        {
            txtDocumento.Clear();
            txtNombreCompleto.Clear();
            txtTelefono.Clear();
            cboGenero.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }
    }
}
