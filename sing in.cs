﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Alex_Admin
{
    public partial class sing_in : Form
    {


        public sing_in()
        {
            InitializeComponent();
         
           
        }

        private void Already_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void Creare_Click(object sender, EventArgs e)
        {
            this.Close();
            Inregistrare fr = new Inregistrare();
            fr.Show();
    }

      
        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
