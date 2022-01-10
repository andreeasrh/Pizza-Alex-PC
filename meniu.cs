using IronPython.Hosting;
using javax.script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using ScriptEngine = Microsoft.Scripting.Hosting.ScriptEngine;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using com.sun.corba.se.spi.activation;
using System.Net;

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
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Location = new Point(3, 13);

            try
            {
                var Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Server.Bind(new IPEndPoint(IPAddress.Any, 5555));
                Server.Listen(0);

                var client = Server.Accept();
                var array = new byte[4];
                client.Receive(array, 4, SocketFlags.None);
                int length = BitConverter.ToInt32(array);
                array = new byte[length];
                client.Receive(array, length, SocketFlags.None);
                MessageBox.Show($"O noua comanda a fost primita! {array}");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1 + "");
            }
        }

        private void butRestaurara_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            

        }

        private void butRestaurara_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(867, 543);
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            vizulizareMeniu fr = new vizulizareMeniu();
            fr.Show();
        }

        private void butComenziF_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel2.Location = new Point(3, 13);
        }

        private void butTable_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(3, 13);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

        }
        public void cmd(string command)
        {
            string currentstatus;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process myprocess = new Process();
            try
            {
                startInfo.FileName = "cmd"; //
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false; //'required to redirect
                startInfo.CreateNoWindow = true; // '<---- creates no window, obviously
                myprocess.StartInfo = startInfo; //
                myprocess.Start(); //
                System.IO.StreamReader SR;
                System.IO.StreamWriter SW;
                SR = myprocess.StandardOutput;
                SW = myprocess.StandardInput;
                SW.WriteLine(command); // 'the command you wish to run.....
                SW.WriteLine("exit"); // 'exits command prompt window
                currentstatus = SR.ReadToEnd();
                SW.Close();
                SR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error");
            }

        }
        private void btnServer_Click(object sender, EventArgs e)
        {
            
          

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
