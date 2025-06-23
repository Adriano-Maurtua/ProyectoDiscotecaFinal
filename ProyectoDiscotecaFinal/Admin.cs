using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscotecaFinal
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnMantenedorCliente_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario Admin

            MantenedorCliente frm = new MantenedorCliente();
            frm.ShowDialog(); // Muestra MantenedorCliente de forma modal

            this.Show(); // Vuelve a mostrar Admin cuando se cierre el otro
        }

        private void btnMantenedorPromocion_Click(object sender, EventArgs e)
        {
            MantenedorProm frm = new MantenedorProm();
            frm.ShowDialog();
            this.Show();
        }

        private void btnMantenedorZona_Click(object sender, EventArgs e)
        {
            MantenedorZonaBox zonaForm = new MantenedorZonaBox();
            zonaForm.Show();
            this.Hide();

        }

        private void btnReprogramar_Click(object sender, EventArgs e)
        {
            ReprogramarReserva reprograma = new ReprogramarReserva();
            reprograma.Show();
            this.Hide();
        }

        private void btnVolverAdmin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
