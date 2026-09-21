using System;
using System.Windows.Forms;

namespace Problema6_JoseContrerasIVC
{
    public partial class Form1 : Form
    {
        private int volumen = 1;
        private int canal = 1;
        private bool encendida = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncenderApagar_Click(object sender, EventArgs e)
        {
            encendida = !encendida;

            if (encendida)
            {
                LblPantalla.Text = "CANAL: " + canal + " | VOLUMEN: " + volumen;
            }
            else
            {
                LblPantalla.Text = "TV APAGADA";
            }
        }

        private void btnSubirVolumen_Click(object sender, EventArgs e)
        {
            if (!encendida)
            {
                LblPantalla.Text = "TV APAGADA";
                return;
            }

            if (volumen < 30)
            {
                volumen++;
            }

            LblPantalla.Text = "CANAL: " + canal + " | VOLUMEN: " + volumen;
        }

        private void btnBajarVolumen_Click(object sender, EventArgs e)
        {
            if (!encendida)
            {
                LblPantalla.Text = "TV APAGADA";
                return;
            }

            if (volumen > 1)
            {
                volumen--;
            }

            LblPantalla.Text = "CANAL: " + canal + " | VOLUMEN: " + volumen;
        }

        private void btnSubirCanal_Click(object sender, EventArgs e)
        {
            if (!encendida)
            {
                LblPantalla.Text = "TV APAGADA";
                return;
            }

            if (canal < 75)
            {
                canal++;
            }

            LblPantalla.Text = "CANAL: " + canal + " | VOLUMEN: " + volumen;
        }

        private void btnBajarCanal_Click(object sender, EventArgs e)
        {
            if (!encendida)
            {
                LblPantalla.Text = "TV APAGADA";
                return;
            }

            if (canal > 1)
            {
                canal--;
            }

            LblPantalla.Text = "CANAL: " + canal + " | VOLUMEN: " + volumen;
        }
    }
}