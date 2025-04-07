using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "1";
            }
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "2";
            }
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "3";
            }
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "4";
            }
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "5";
            }
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "6";
            }
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "7";
            }
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "8";
            }
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "9";
            }
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "0";
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "+";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "-";
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "x";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "/";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text.Length < 10)
            {
                lblResultado.Text += "=";
            }
        }
    }
}