using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Alex_Admin.vizMeniu
{
    public partial class Specialitati : Form
    {
        public Specialitati()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vizMeniu.antreuri fr = new antreuri();
            fr.Show();
        }
    }
}
