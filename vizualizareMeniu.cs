using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Alex_Admin
{
    public partial class vizualizareMeniu : Form
    {
        public vizualizareMeniu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.produseTraditionale fr = new vizMeniu.produseTraditionale();
            fr.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.antreuri fr = new vizMeniu.antreuri();
            fr.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.pizza fr = new vizMeniu.pizza();
            fr.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.paste fr = new vizMeniu.paste();
            fr.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.ciorbe fr = new vizMeniu.ciorbe();
            fr.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.preparatePui fr = new vizMeniu.preparatePui();
            fr.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.preparatePorc fr = new vizMeniu.preparatePorc();
            fr.Show();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.preparateVita fr = new vizMeniu.preparateVita();
            fr.Show();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.preparatePeste fr = new vizMeniu.preparatePeste();
            fr.Show();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.Specialitati fr = new vizMeniu.Specialitati();
            fr.Show();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.Garnituri fr = new vizMeniu.Garnituri();
            fr.Show();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.Salate fr = new vizMeniu.Salate();
            fr.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.Desert fr = new vizMeniu.Desert();
            fr.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.Racoritoare fr = new vizMeniu.Racoritoare();
            fr.Show();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.bauturiCalde fr = new vizMeniu.bauturiCalde();
            fr.Show();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            vizMeniu.Alcool fr = new vizMeniu.Alcool();
            fr.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            meniu fr = new meniu();
            fr.Show();

        }
    }
}
