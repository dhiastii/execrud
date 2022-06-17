namespace execrud
{
    partial class HalamanAwal
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
            this.startbut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startbut
            // 
            this.startbut.BackColor = System.Drawing.Color.Ivory;
            this.startbut.Location = new System.Drawing.Point(230, 344);
            this.startbut.Name = "startbut";
            this.startbut.Size = new System.Drawing.Size(123, 23);
            this.startbut.TabIndex = 0;
            this.startbut.Text = "Mulai Aplikasi";
            this.startbut.UseVisualStyleBackColor = false;
            this.startbut.Click += new System.EventHandler(this.startbut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::execrud.Properties.Resources.APLIKASI_READ_BOOK;
            this.pictureBox1.Location = new System.Drawing.Point(56, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // HalamanAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(615, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startbut);
            this.Name = "HalamanAwal";
            this.Text = "Read Book";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

