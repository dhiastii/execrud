namespace execrud
{
    partial class Halaman2
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
            this.adminbut = new System.Windows.Forms.Button();
            this.anggotabut = new System.Windows.Forms.Button();
            this.bukubut = new System.Windows.Forms.Button();
            this.backbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminbut
            // 
            this.adminbut.Location = new System.Drawing.Point(59, 308);
            this.adminbut.Name = "adminbut";
            this.adminbut.Size = new System.Drawing.Size(75, 23);
            this.adminbut.TabIndex = 0;
            this.adminbut.Text = "Admin";
            this.adminbut.UseVisualStyleBackColor = true;
            this.adminbut.Click += new System.EventHandler(this.adminbut_Click);
            // 
            // anggotabut
            // 
            this.anggotabut.Location = new System.Drawing.Point(263, 308);
            this.anggotabut.Name = "anggotabut";
            this.anggotabut.Size = new System.Drawing.Size(75, 23);
            this.anggotabut.TabIndex = 1;
            this.anggotabut.Text = "Anggota";
            this.anggotabut.UseVisualStyleBackColor = true;
            this.anggotabut.Click += new System.EventHandler(this.anggotabut_Click);
            // 
            // bukubut
            // 
            this.bukubut.Location = new System.Drawing.Point(450, 308);
            this.bukubut.Name = "bukubut";
            this.bukubut.Size = new System.Drawing.Size(75, 23);
            this.bukubut.TabIndex = 2;
            this.bukubut.Text = "Buku";
            this.bukubut.UseVisualStyleBackColor = true;
            this.bukubut.Click += new System.EventHandler(this.bukubut_Click);
            // 
            // backbut
            // 
            this.backbut.Location = new System.Drawing.Point(13, 416);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(75, 23);
            this.backbut.TabIndex = 3;
            this.backbut.Text = "Back";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // Halaman2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 451);
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.bukubut);
            this.Controls.Add(this.anggotabut);
            this.Controls.Add(this.adminbut);
            this.Name = "Halaman2";
            this.Text = "Halaman2";
            this.Load += new System.EventHandler(this.Halaman2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminbut;
        private System.Windows.Forms.Button anggotabut;
        private System.Windows.Forms.Button bukubut;
        private System.Windows.Forms.Button backbut;
    }
}