
namespace Pizza_Alex_Admin
{
    partial class sing_in
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sing_in));
            this.logo = new System.Windows.Forms.Button();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.loginT = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.showboxLogin = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.clearRegister2 = new System.Windows.Forms.Button();
            this.pictureboxLogin = new System.Windows.Forms.PictureBox();
            this.url = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.logo, "logo");
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.ForeColor = System.Drawing.SystemColors.Window;
            this.logo.Name = "logo";
            this.logo.UseVisualStyleBackColor = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // passwordLogin
            // 
            this.passwordLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.passwordLogin, "passwordLogin");
            this.passwordLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordLogin.Name = "passwordLogin";
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Password.Name = "Password";
            // 
            // usernameLogin
            // 
            this.usernameLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.usernameLogin, "usernameLogin");
            this.usernameLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameLogin.Name = "usernameLogin";
            // 
            // labelUser
            // 
            resources.ApplyResources(this.labelUser, "labelUser");
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelUser.Name = "labelUser";
            // 
            // loginT
            // 
            resources.ApplyResources(this.loginT, "loginT");
            this.loginT.BackColor = System.Drawing.Color.Transparent;
            this.loginT.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.loginT.Name = "loginT";
            this.loginT.Click += new System.EventHandler(this.loginT_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Transparent;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Register, "Register");
            this.Register.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Register.Name = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // showboxLogin
            // 
            resources.ApplyResources(this.showboxLogin, "showboxLogin");
            this.showboxLogin.BackColor = System.Drawing.Color.Transparent;
            this.showboxLogin.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.showboxLogin.Name = "showboxLogin";
            this.showboxLogin.UseVisualStyleBackColor = false;
            this.showboxLogin.CheckedChanged += new System.EventHandler(this.showboxLogin_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearRegister2
            // 
            this.clearRegister2.BackColor = System.Drawing.Color.Red;
            this.clearRegister2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.clearRegister2, "clearRegister2");
            this.clearRegister2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.clearRegister2.Name = "clearRegister2";
            this.clearRegister2.UseVisualStyleBackColor = false;
            this.clearRegister2.Click += new System.EventHandler(this.clearRegister2_Click);
            // 
            // pictureboxLogin
            // 
            this.pictureboxLogin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureboxLogin, "pictureboxLogin");
            this.pictureboxLogin.Name = "pictureboxLogin";
            this.pictureboxLogin.TabStop = false;
            this.pictureboxLogin.Click += new System.EventHandler(this.pictureboxRegister_Click);
            // 
            // url
            // 
            resources.ApplyResources(this.url, "url");
            this.url.BackColor = System.Drawing.Color.Transparent;
            this.url.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.url.Name = "url";
            this.url.Click += new System.EventHandler(this.url_Click);
            // 
            // sing_in
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.url);
            this.Controls.Add(this.pictureboxLogin);
            this.Controls.Add(this.clearRegister2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.showboxLogin);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.usernameLogin);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.loginT);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "sing_in";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logo;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox usernameLogin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label loginT;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.CheckBox showboxLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearRegister2;
        private System.Windows.Forms.PictureBox pictureboxLogin;
        private System.Windows.Forms.Label url;
    }
}