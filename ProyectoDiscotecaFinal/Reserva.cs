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
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            // Llenar el DomainUpDown con números del 1 al 12
            for (int i = 1; i <= 12; i++)
            {
                domainCantidad.Items.Add(i.ToString());
            }

            domainCantidad.SelectedIndex = 0; // Por defecto en 1
            domainCantidad.Wrap = false;      // No permite pasar del 12 al 1
            domainCantidad.ReadOnly = true;   // El usuario no puede escribir

            int cantidadPersonas = int.Parse(domainCantidad.Text);

            // Validación extra (opcional)
            if (cantidadPersonas >= 1 && cantidadPersonas <= 12)
            {
                MessageBox.Show("Cantidad seleccionada: " + cantidadPersonas);
            }
            else
            {
                MessageBox.Show("La cantidad debe estar entre 1 y 12");
            }
        }

    }
}
