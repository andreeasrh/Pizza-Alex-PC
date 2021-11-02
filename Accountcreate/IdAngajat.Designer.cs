
namespace Pizza_Alex_Admin.Accountcreate
{
    partial class IdAngajat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdBox = new System.Windows.Forms.TextBox();
            this.employee = new System.Windows.Forms.Label();
            this.Creare = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.Color.PeachPuff;
            this.IdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.IdBox.Location = new System.Drawing.Point(72, 111);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(140, 20);
            this.IdBox.TabIndex = 0;
            this.IdBox.TextChanged += new System.EventHandler(this.IdBox_TextChanged);
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.BackColor = System.Drawing.Color.Transparent;
            this.employee.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.employee.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.employee.Location = new System.Drawing.Point(97, 57);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(109, 23);
            this.employee.TabIndex = 2;
            this.employee.Text = "ID Employee";
            // 
            // Creare
            // 
            this.Creare.BackColor = System.Drawing.Color.Chocolate;
            this.Creare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Creare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Creare.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Creare.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Creare.Location = new System.Drawing.Point(18, 163);
            this.Creare.Margin = new System.Windows.Forms.Padding(0);
            this.Creare.Name = "Creare";
            this.Creare.Size = new System.Drawing.Size(242, 48);
            this.Creare.TabIndex = 9;
            this.Creare.Text = "Create Account";
            this.Creare.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Peru;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Close.Location = new System.Drawing.Point(62, 233);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(150, 34);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // IdAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Creare);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.IdBox);
            this.Name = "IdAngajat";
            this.Size = new System.Drawing.Size(276, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.Button Creare;
        private System.Windows.Forms.Button Close;
    }
}
