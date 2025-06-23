using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProyectoDiscotecaFinal
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            // Llenar el DomainUpDown con números del 1 al 12
            for (int i = 1; i <= 10; i++)
            {
                domainCantidad.Items.Add(i.ToString());
            }

            domainCantidad.SelectedIndex = 0; // Por defecto en 1
            domainCantidad.Wrap = false;      // No permite pasar del 10 al 1
            domainCantidad.ReadOnly = true;   // El usuario no puede escribir
        }

        private void domainCantidad_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(domainCantidad.Text);

            Integrantes formIntegrantes = new Integrantes(cantidad);
            formIntegrantes.Show();
        }
    }
}
