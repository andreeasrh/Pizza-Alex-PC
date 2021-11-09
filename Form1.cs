using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Alex_Admin
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();

            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://alexpizza.ro/");
        }

        private void ShowBox_CheckedChanged(object sender, EventArgs e)
        {
            if (registerboxLogin.Checked)
            {
                passwordRegister.PasswordChar = '\0';
                confirmpassRegister.PasswordChar = '\0';
            }
            else
            {
                passwordRegister.PasswordChar = '•';
                confirmpassRegister.PasswordChar = '•';
            }
        }

        private void label2_Click(object sender, EventArgs e)
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
            bool validated = true;



            if (((usernameRegister.Text == "") || (passwordRegister.Text == "")) || (confirmpassRegister.Text == ""))
            {
                MessageBox.Show("YOU CANNOT SIGN IN WITH BLANK SPACE! :)", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (passwordRegister.Text != confirmpassRegister.Text)
            {

                statuspass.Visible = true;

            }

            else if ((passwordRegister.Text == confirmpassRegister.Text) && confirmpassRegister.Text.Length < 5)
            {
                MessageBox.Show("Your pass is too short! :( You need to have up to 6 charachters!", "Password problem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (passwordRegister.Text == confirmpassRegister.Text)
            {

                string host = "host =172.24.1.199;";
                string port = "port =3306;";
                string db = "database =dbproiectjava;";
                string user = "user=root;";
                string pass = "password=PizzaAlexProiect2021@@;";
                string conString = $"{host}{port}{db}{user}{pass}";

                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand();
                DataTable sqlDt = new DataTable();
                MySqlDataAdapter Dta = new MySqlDataAdapter();
                MySqlDataReader sqlRd;
                DataSet DS = new DataSet();


                cmd.CommandText = $"SELECT username from `dbproiectjava`.`users2` WHERE `username`=\u0022{Encrypt(usernameRegister.Text)}\u0022;";
                con.Open();
                cmd.Connection = con;
                sqlRd = cmd.ExecuteReader();
                sqlDt.Load(sqlRd);
                bool verified = false;
                bool verified2 = false;

                sqlRd = cmd.ExecuteReader();
                if (sqlRd.Read() == true)
                { verified = true; }
                con.Close();


                ///verified2 == true 


                if (verified == false)

                {
                    cmd.CommandText = "INSERT INTO `dbproiectjava`.`users2` (`username`,`pass`) VALUES " + '(' + '\u0022' + Encrypt(usernameRegister.Text) + '\u0022' + ","+ '\u0022' + Encrypt(passwordRegister.Text) + '\u0022' + ")";

                    con.Open();
                    cmd.Connection = con;
                    sqlRd = cmd.ExecuteReader();
                    sqlDt.Load(sqlRd);
                    con.Close();


                    MessageBox.Show("YEEY!Your Account has been Succes!Go to Login Page!", "Account Registred!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();

                    sing_in form = new sing_in();
                    form.Show();
                }
                else if (verified == true)
                {
                    MessageBox.Show("Username is taken! Try a new one!", "Username Problem", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            sing_in sg = new sing_in();
            sg.Show();
        }

        private void textUserr_TextChanged(object sender, EventArgs e)
        {

        }


     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (registerboxLogin.Checked)
            {
                passwordRegister.PasswordChar = '\0';
                confirmpassRegister.PasswordChar = '\0';
                if (passwordRegister.Text == confirmpassRegister.Text)
                {
                    statuspass.Visible = false;
                }
            }
            else
            {
                passwordRegister.PasswordChar = '•';
                confirmpassRegister.PasswordChar = '•';
            }
        }


        public string pass1 = "NULL";
        public string pass2 = "NULL";
     

        public void password1(object sender, EventArgs e)
        {
            pass1 = passwordRegister.Text;
        }

        public void password2(object sender, EventArgs e)
        {
            pass2 = confirmpassRegister.Text;

        }

        private void clearRegister_Click(object sender, EventArgs e)
        {
            usernameRegister.Text = "";
            passwordRegister.Text = "";
            confirmpassRegister.Text = "";
        }

        private void statuspass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureboxRegister_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://alexpizza.ro/",
                UseShellExecute = true
            });
        }

        private void url_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://alexpizza.ro/",
                UseShellExecute = true
            });
        }
    }
}
