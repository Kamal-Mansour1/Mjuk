using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skolan2020
{
    public partial class Form1 : Form
    {
        List<elev> elever = new List<elev>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapaElev_Click(object sender, EventArgs e)
        {
            elever.Add(new elev(txtFörnamn.Text, txtEfternamn.Text, double.Parse(txtLängd.Text), 
                double.Parse(txtVikt.Text), dateTimePicker1.Value));

        }

        private void btnHelaNamnet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(elever[0].helanamnet());
        }

        private void btnIfMyndig_Click(object sender, EventArgs e)
        {
            if (elever[0].Ärmyndig() == true)
            {
                MessageBox.Show("Ja, hen är myndig!");
            }
            else
            {
                MessageBox.Show("Nej, hen är inte myndig!");
            }
        }

        private void btnBeräknaBMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(elever[0].BeräknaBMI().ToString());
        }
    }
}
