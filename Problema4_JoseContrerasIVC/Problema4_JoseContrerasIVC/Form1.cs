namespace Problema4_JoseContrerasIVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevosDatos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtNombreCompleto.Clear();

            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Text = txtNombre.Text + " "
            + txtApellidoPaterno.Text + " "
            + txtApellidoMaterno.Text;
        }
    }
}
