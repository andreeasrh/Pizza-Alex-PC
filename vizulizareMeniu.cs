using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Alex_Admin
{
    public partial class vizulizareMeniu : Form
    {
        public vizulizareMeniu()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
            meniu fr = new meniu();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vizMeniu.antreuri fr = new vizMeniu.antreuri();
            fr.Show();
        }
    }
}
