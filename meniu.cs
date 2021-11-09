using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Alex_Admin
{
    public partial class meniu : Form
    {
        public meniu()
        {
            InitializeComponent();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelSetariSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void meniu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void panelDreapta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            

        }

        private void minimise_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void panelCentru_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butComenzi_Click(object sender, EventArgs e)
        {
            
        }

        private void butRestaurara_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            

        }

        private void butRestaurara_Click_1(object sender, EventArgs e)
        {
            
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            vizulizareMeniu fr = new vizulizareMeniu();
            fr.Show();
        }
    }
}
