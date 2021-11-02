
namespace Pizza_Alex_Admin
{
    partial class meniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meniu));
            this.panelDreapta = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSus = new System.Windows.Forms.Panel();
            this.minimise = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.ptnSlide = new System.Windows.Forms.PictureBox();
            this.panelCentru = new System.Windows.Forms.Panel();
            this.panelDreapta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDreapta
            // 
            this.panelDreapta.BackColor = System.Drawing.Color.Chocolate;
            this.panelDreapta.Controls.Add(this.pictureBox2);
            this.panelDreapta.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDreapta.Location = new System.Drawing.Point(0, 0);
            this.panelDreapta.Name = "panelDreapta";
            this.panelDreapta.Size = new System.Drawing.Size(250, 612);
            this.panelDreapta.TabIndex = 0;
            this.panelDreapta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDreapta_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(63, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 64);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelSus
            // 
            this.panelSus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSus.Controls.Add(this.minimise);
            this.panelSus.Controls.Add(this.max);
            this.panelSus.Controls.Add(this.close);
            this.panelSus.Controls.Add(this.ptnSlide);
            this.panelSus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSus.Location = new System.Drawing.Point(250, 0);
            this.panelSus.Name = "panelSus";
            this.panelSus.Size = new System.Drawing.Size(861, 69);
            this.panelSus.TabIndex = 1;
            // 
            // minimise
            // 
            this.minimise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimise.BackgroundImage")));
            this.minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimise.Location = new System.Drawing.Point(732, 12);
            this.minimise.Name = "minimise";
            this.minimise.Size = new System.Drawing.Size(35, 35);
            this.minimise.TabIndex = 3;
            this.minimise.UseVisualStyleBackColor = true;
            this.minimise.Click += new System.EventHandler(this.minimise_Click_1);
            // 
            // max
            // 
            this.max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("max.BackgroundImage")));
            this.max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.max.Location = new System.Drawing.Point(773, 12);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(35, 35);
            this.max.TabIndex = 2;
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.minimise_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(814, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 35);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ptnSlide
            // 
            this.ptnSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptnSlide.BackgroundImage")));
            this.ptnSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptnSlide.Location = new System.Drawing.Point(6, 12);
            this.ptnSlide.Name = "ptnSlide";
            this.ptnSlide.Size = new System.Drawing.Size(35, 35);
            this.ptnSlide.TabIndex = 0;
            this.ptnSlide.TabStop = false;
            this.ptnSlide.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelCentru
            // 
            this.panelCentru.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCentru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentru.Location = new System.Drawing.Point(250, 69);
            this.panelCentru.Name = "panelCentru";
            this.panelCentru.Size = new System.Drawing.Size(861, 543);
            this.panelCentru.TabIndex = 0;
            this.panelCentru.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentru_Paint);
            // 
            // meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1111, 612);
            this.Controls.Add(this.panelCentru);
            this.Controls.Add(this.panelSus);
            this.Controls.Add(this.panelDreapta);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "meniu";
            this.Text = "Pizza Alex";
            this.Load += new System.EventHandler(this.meniu_Load);
            this.panelDreapta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDreapta;
        private System.Windows.Forms.Panel panelSus;
        private System.Windows.Forms.PictureBox ptnSlide;
        private System.Windows.Forms.Panel panelCentru;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimise;
        private System.Windows.Forms.Button max;
    }
}