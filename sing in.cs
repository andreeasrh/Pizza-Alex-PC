using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
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

        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private void Register_Click(object sender, EventArgs e)
        {
          

            if (usernameLogin.Text == "")
            {
                MessageBox.Show("Enter your username!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordLogin.Text == "")
            {

                MessageBox.Show("Enter your password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //string host = "host =172.24.1.199;";
                string host = "host =127.0.0.1;";
                string port = "port =3306;";
                string db = "database =dbproiectjava;";
                string user = "user=root;";
                string pass = "password=PizzaAlexProiect2021@@;";
                string conString = $"{host}{port}{db}{user}{pass}";

                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand();
                DataTable sqlDt = new DataTable();
                MySqlDataAdapter Da = new MySqlDataAdapter();
                MySqlDataReader sqlRd;



                cmd.CommandText = $"SELECT username from `dbproiectjava`.`users2` WHERE `username`=\u0022{Encrypt(usernameLogin.Text)}\u0022 AND `pass`=\u0022{Encrypt(passwordLogin.Text)}\u0022;";
                con.Open();
                cmd.Connection = con;
                sqlRd = cmd.ExecuteReader();
                sqlDt.Load(sqlRd);
                bool verified = false;

                sqlRd = cmd.ExecuteReader();
                if (sqlRd.Read() == true)
                { verified = true; }
                con.Close();



                if (verified == true)
                {
                    user = usernameLogin.Text;

                    MessageBox.Show("Login Succesfully!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Hide();
                    meniu mn = new meniu();
                    mn.Show();
                }
                else
                {


                    MessageBox.Show("User dont exist.Make an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameLogin.Text = "";
                    passwordLogin.Text = "";
                }

            }
        
        
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Inregistrare fr = new Inregistrare();
            fr.Show();
        }

        private void clearRegister2_Click(object sender, EventArgs e)
        {
            usernameLogin.Text = "";
            passwordLogin.Text = "";
        }

        private void pictureboxRegister_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void showboxLogin_CheckedChanged(object sender, EventArgs e)
        {

            if (showboxLogin.Checked)
            {
                passwordLogin.PasswordChar = '\0';
         
            }
            else
            {
                passwordLogin.PasswordChar = '•';
              
            }
        }

        private void url_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://alexpizza.ro/",
                UseShellExecute = true
            });
        }

        private void logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://alexpizza.ro/",
                UseShellExecute = true
            });
        }

        private void loginT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://alexpizza.ro/",
                UseShellExecute = true
            });
        }
    }
}
