using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitTestVB.Lgoic;

namespace UnitTestVB
{
    public partial class Form1 : Form
    {
        Logica _logica = new Logica();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            int getal = 0;
            if(txtGetal1.Text != null) 
            {
                getal = Convert.ToInt32(txtGetal1.Text);
            }

            double resultaat = _logica.BerekenVierkantwortel(getal);

            txtResultaatGetal.Text = resultaat.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGetal1.Text = txtGetal2.Text = txtResultaatGetal.Text = txtStringInput.Text = txtStringResultaat.Text = String.Empty;
        }
    }
}
