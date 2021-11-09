
namespace Pizza_Alex_Admin
{
    partial class vizulizareMeniu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vizulizareMeniu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRegister_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnRegister_Click);
            this.panel1.Location = new System.Drawing.Point(-11, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 576);
            this.panel1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRegister_Click
            // 
            this.btnRegister_Click.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister_Click.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRegister_Click.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnRegister_Click.Location = new System.Drawing.Point(23, 412);
            this.btnRegister_Click.Name = "btnRegister_Click";
            this.btnRegister_Click.Size = new System.Drawing.Size(92, 40);
            this.btnRegister_Click.TabIndex = 9;
            this.btnRegister_Click.Text = "Back";
            this.btnRegister_Click.UseVisualStyleBackColor = false;
            this.btnRegister_Click.Click += new System.EventHandler(this.btnRegister_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 66);
            this.label1.MaximumSize = new System.Drawing.Size(200, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antreuri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vizulizareMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vizulizareMeniu";
            this.Text = "Vizualizare Meniu Pizza Alex";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRegister_Click;
        public System.Windows.Forms.Label label1;
    }
}