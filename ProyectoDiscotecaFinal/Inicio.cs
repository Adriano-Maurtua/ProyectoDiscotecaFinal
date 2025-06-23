namespace ProyectoDiscotecaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin formAdmin = new Admin();
            formAdmin.Show();
            this.Hide(); 
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Reserva formReserva = new Reserva();
            formReserva.Show();
            this.Hide(); 
        }
    }
}
