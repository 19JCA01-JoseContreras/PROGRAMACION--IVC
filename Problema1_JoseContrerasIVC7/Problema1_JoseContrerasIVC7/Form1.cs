using System.Globalization;

namespace Problema1_JoseContrerasIVC7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDia.Clear();
            txtMes.Clear();
            txtAnio.Clear();
            txtResultado.Clear();

            txtDia.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dia = int.Parse(txtDia.Text);
                int mes = int.Parse(txtMes.Text);
                int anio = int.Parse(txtAnio.Text);

                DateTime fecha = new DateTime(anio, mes, dia);

                CultureInfo cultura = new CultureInfo("es-ES");

                txtResultado.Text = fecha.ToString(
                    "d 'de' MMMM 'de' yyyy",
                    cultura);
            }
            catch
            {
                MessageBox.Show("Ingrese una fecha válida.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
