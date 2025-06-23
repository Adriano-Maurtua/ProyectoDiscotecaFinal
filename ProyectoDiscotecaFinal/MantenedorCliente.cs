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
        private List<Cliente> listaClientes = new List<Cliente>();
        private int filaSeleccionada = -1;
        private string rutaArchivo = "clientes.txt";

        public MantenedorCliente()
        {
            InitializeComponent();
            LeerArchivo();
            ActualizarGrid();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void MantenedorCliente_Load(object sender, EventArgs e)
        {
            // Este método puede usarse más adelante si lo necesitas.
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente
            {
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Telefono = txtTelefono.Text,
                Genero = cboGenero.Text,
                Categoria = cboCategoria.Text
            };

            listaClientes.Add(cli);
            ActualizarGrid();
            GuardarEnArchivo();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0 && filaSeleccionada < listaClientes.Count)
            {
                Cliente cli = listaClientes[filaSeleccionada];
                cli.Documento = txtDocumento.Text;
                cli.NombreCompleto = txtNombreCompleto.Text;
                cli.Telefono = txtTelefono.Text;
                cli.Genero = cboGenero.Text;
                cli.Categoria = cboCategoria.Text;

                ActualizarGrid();
                GuardarEnArchivo();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0 && filaSeleccionada < listaClientes.Count)
            {
                listaClientes.RemoveAt(filaSeleccionada);
                ActualizarGrid();
                GuardarEnArchivo();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        private void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaClientes;
        }

        private void LimpiarCampos()
        {
            txtDocumento.Clear();
            txtNombreCompleto.Clear();
            txtTelefono.Clear();
            cboGenero.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            filaSeleccionada = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            if (filaSeleccionada >= 0 && filaSeleccionada < listaClientes.Count)
            {
                Cliente cli = listaClientes[filaSeleccionada];
                txtDocumento.Text = cli.Documento;
                txtNombreCompleto.Text = cli.NombreCompleto;
                txtTelefono.Text = cli.Telefono;
                cboGenero.Text = cli.Genero;
                cboCategoria.Text = cli.Categoria;
            }
        }

        private void GuardarEnArchivo()
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (Cliente cli in listaClientes)
                {
                    sw.WriteLine($"{cli.Documento}|{cli.NombreCompleto}|{cli.Telefono}|{cli.Genero}|{cli.Categoria}");
                }
            }
        }

        private void LeerArchivo()
        {
            listaClientes.Clear();

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split('|');
                    if (datos.Length == 5)
                    {
                        Cliente cli = new Cliente
                        {
                            Documento = datos[0],
                            NombreCompleto = datos[1],
                            Telefono = datos[2],
                            Genero = datos[3],
                            Categoria = datos[4]
                        };
                        listaClientes.Add(cli);
                    }
                }
            }
        }
    }
}
