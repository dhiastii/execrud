namespace execrud
{
    partial class HalamanBuku
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
            this.backbut = new System.Windows.Forms.Button();
            this.addbut = new System.Windows.Forms.Button();
            this.textBoxtahun = new System.Windows.Forms.TextBox();
            this.textBoxnmpengarang = new System.Windows.Forms.TextBox();
            this.textBoxjudul = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.editbut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.tahunAnggota = new System.Windows.Forms.Label();
            this.asalKota = new System.Windows.Forms.Label();
            this.idanggota = new System.Windows.Forms.Label();
            this.namaAnggota = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.execrudDataSet2 = new execrud.execrudDataSet2();
            this.dataBukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBukuTableAdapter = new execrud.execrudDataSet2TableAdapters.dataBukuTableAdapter();
            this.idAplikasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPengarangBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunTerbitBukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBukuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backbut
            // 
            this.backbut.Location = new System.Drawing.Point(13, 415);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(75, 23);
            this.backbut.TabIndex = 0;
            this.backbut.Text = "Back";
            this.backbut.UseVisualStyleBackColor = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(40, 165);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(75, 23);
            this.addbut.TabIndex = 24;
            this.addbut.Text = "Add";
            this.addbut.UseVisualStyleBackColor = true;
            // 
            // textBoxtahun
            // 
            this.textBoxtahun.Location = new System.Drawing.Point(188, 127);
            this.textBoxtahun.Name = "textBoxtahun";
            this.textBoxtahun.Size = new System.Drawing.Size(64, 20);
            this.textBoxtahun.TabIndex = 23;
            // 
            // textBoxnmpengarang
            // 
            this.textBoxnmpengarang.Location = new System.Drawing.Point(188, 97);
            this.textBoxnmpengarang.Name = "textBoxnmpengarang";
            this.textBoxnmpengarang.Size = new System.Drawing.Size(211, 20);
            this.textBoxnmpengarang.TabIndex = 22;
            // 
            // textBoxjudul
            // 
            this.textBoxjudul.Location = new System.Drawing.Point(188, 67);
            this.textBoxjudul.Name = "textBoxjudul";
            this.textBoxjudul.Size = new System.Drawing.Size(211, 20);
            this.textBoxjudul.TabIndex = 21;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(188, 36);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(137, 20);
            this.textBoxid.TabIndex = 20;
            // 
            // editbut
            // 
            this.editbut.Location = new System.Drawing.Point(319, 166);
            this.editbut.Name = "editbut";
            this.editbut.Size = new System.Drawing.Size(75, 23);
            this.editbut.TabIndex = 19;
            this.editbut.Text = "Edit";
            this.editbut.UseVisualStyleBackColor = true;
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(177, 166);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(75, 23);
            this.deletebut.TabIndex = 18;
            this.deletebut.Text = "Hapus";
            this.deletebut.UseVisualStyleBackColor = true;
            // 
            // tahunAnggota
            // 
            this.tahunAnggota.AutoSize = true;
            this.tahunAnggota.Location = new System.Drawing.Point(37, 130);
            this.tahunAnggota.Name = "tahunAnggota";
            this.tahunAnggota.Size = new System.Drawing.Size(68, 13);
            this.tahunAnggota.TabIndex = 17;
            this.tahunAnggota.Text = "Tahun Terbit";
            // 
            // asalKota
            // 
            this.asalKota.AutoSize = true;
            this.asalKota.Location = new System.Drawing.Point(37, 100);
            this.asalKota.Name = "asalKota";
            this.asalKota.Size = new System.Drawing.Size(90, 13);
            this.asalKota.TabIndex = 16;
            this.asalKota.Text = "Nama Pengarang";
            // 
            // idanggota
            // 
            this.idanggota.AutoSize = true;
            this.idanggota.Location = new System.Drawing.Point(37, 39);
            this.idanggota.Name = "idanggota";
            this.idanggota.Size = new System.Drawing.Size(44, 13);
            this.idanggota.TabIndex = 15;
            this.idanggota.Text = "Id Buku";
            // 
            // namaAnggota
            // 
            this.namaAnggota.AutoSize = true;
            this.namaAnggota.Location = new System.Drawing.Point(37, 70);
            this.namaAnggota.Name = "namaAnggota";
            this.namaAnggota.Size = new System.Drawing.Size(60, 13);
            this.namaAnggota.TabIndex = 14;
            this.namaAnggota.Text = "Judul Buku";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAplikasiDataGridViewTextBoxColumn,
            this.idBukuDataGridViewTextBoxColumn,
            this.judulBukuDataGridViewTextBoxColumn,
            this.namaPengarangBukuDataGridViewTextBoxColumn,
            this.tahunTerbitBukuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataBukuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // execrudDataSet2
            // 
            this.execrudDataSet2.DataSetName = "execrudDataSet2";
            this.execrudDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBukuBindingSource
            // 
            this.dataBukuBindingSource.DataMember = "dataBuku";
            this.dataBukuBindingSource.DataSource = this.execrudDataSet2;
            // 
            // dataBukuTableAdapter
            // 
            this.dataBukuTableAdapter.ClearBeforeFill = true;
            // 
            // idAplikasiDataGridViewTextBoxColumn
            // 
            this.idAplikasiDataGridViewTextBoxColumn.DataPropertyName = "Id_Aplikasi";
            this.idAplikasiDataGridViewTextBoxColumn.HeaderText = "Id_Aplikasi";
            this.idAplikasiDataGridViewTextBoxColumn.Name = "idAplikasiDataGridViewTextBoxColumn";
            // 
            // idBukuDataGridViewTextBoxColumn
            // 
            this.idBukuDataGridViewTextBoxColumn.DataPropertyName = "Id_Buku";
            this.idBukuDataGridViewTextBoxColumn.HeaderText = "Id_Buku";
            this.idBukuDataGridViewTextBoxColumn.Name = "idBukuDataGridViewTextBoxColumn";
            // 
            // judulBukuDataGridViewTextBoxColumn
            // 
            this.judulBukuDataGridViewTextBoxColumn.DataPropertyName = "Judul_Buku";
            this.judulBukuDataGridViewTextBoxColumn.HeaderText = "Judul_Buku";
            this.judulBukuDataGridViewTextBoxColumn.Name = "judulBukuDataGridViewTextBoxColumn";
            // 
            // namaPengarangBukuDataGridViewTextBoxColumn
            // 
            this.namaPengarangBukuDataGridViewTextBoxColumn.DataPropertyName = "NamaPengarang_Buku";
            this.namaPengarangBukuDataGridViewTextBoxColumn.HeaderText = "NamaPengarang_Buku";
            this.namaPengarangBukuDataGridViewTextBoxColumn.Name = "namaPengarangBukuDataGridViewTextBoxColumn";
            // 
            // tahunTerbitBukuDataGridViewTextBoxColumn
            // 
            this.tahunTerbitBukuDataGridViewTextBoxColumn.DataPropertyName = "TahunTerbit_Buku";
            this.tahunTerbitBukuDataGridViewTextBoxColumn.HeaderText = "TahunTerbit_Buku";
            this.tahunTerbitBukuDataGridViewTextBoxColumn.Name = "tahunTerbitBukuDataGridViewTextBoxColumn";
            // 
            // HalamanBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.textBoxtahun);
            this.Controls.Add(this.textBoxnmpengarang);
            this.Controls.Add(this.textBoxjudul);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.editbut);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.tahunAnggota);
            this.Controls.Add(this.asalKota);
            this.Controls.Add(this.idanggota);
            this.Controls.Add(this.namaAnggota);
            this.Controls.Add(this.backbut);
            this.Name = "HalamanBuku";
            this.Text = "HalamanBuku";
            this.Load += new System.EventHandler(this.HalamanBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBukuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.Button addbut;
        private System.Windows.Forms.TextBox textBoxtahun;
        private System.Windows.Forms.TextBox textBoxnmpengarang;
        private System.Windows.Forms.TextBox textBoxjudul;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button editbut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Label tahunAnggota;
        private System.Windows.Forms.Label asalKota;
        private System.Windows.Forms.Label idanggota;
        private System.Windows.Forms.Label namaAnggota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private execrudDataSet2 execrudDataSet2;
        private System.Windows.Forms.BindingSource dataBukuBindingSource;
        private execrudDataSet2TableAdapters.dataBukuTableAdapter dataBukuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAplikasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPengarangBukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunTerbitBukuDataGridViewTextBoxColumn;
    }
}