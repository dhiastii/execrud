namespace execrud
{
    partial class HalamanAdmin
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
            this.textBoxtahun = new System.Windows.Forms.TextBox();
            this.textBoxaskot = new System.Windows.Forms.TextBox();
            this.textBoxnama = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.tahunAnggota = new System.Windows.Forms.Label();
            this.asalKota = new System.Windows.Forms.Label();
            this.idanggota = new System.Windows.Forms.Label();
            this.namaAnggota = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.execrudDataSet1 = new execrud.execrudDataSet1();
            this.dataAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataAdminTableAdapter = new execrud.execrudDataSet1TableAdapters.dataAdminTableAdapter();
            this.idAplikasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asalKotaAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorTeleponAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunBergabungAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminBindingSource)).BeginInit();
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
            // textBoxtahun
            // 
            this.textBoxtahun.Location = new System.Drawing.Point(189, 144);
            this.textBoxtahun.Name = "textBoxtahun";
            this.textBoxtahun.Size = new System.Drawing.Size(64, 20);
            this.textBoxtahun.TabIndex = 23;
            // 
            // textBoxaskot
            // 
            this.textBoxaskot.Location = new System.Drawing.Point(189, 88);
            this.textBoxaskot.Name = "textBoxaskot";
            this.textBoxaskot.Size = new System.Drawing.Size(211, 20);
            this.textBoxaskot.TabIndex = 22;
            // 
            // textBoxnama
            // 
            this.textBoxnama.Location = new System.Drawing.Point(189, 58);
            this.textBoxnama.Name = "textBoxnama";
            this.textBoxnama.Size = new System.Drawing.Size(211, 20);
            this.textBoxnama.TabIndex = 21;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(189, 27);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(137, 20);
            this.textBoxid.TabIndex = 20;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(320, 183);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 19;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(178, 183);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 18;
            this.delete.Text = "Hapus";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(41, 183);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 17;
            this.add.Text = "Tambah";
            this.add.UseVisualStyleBackColor = true;
            // 
            // tahunAnggota
            // 
            this.tahunAnggota.AutoSize = true;
            this.tahunAnggota.Location = new System.Drawing.Point(38, 147);
            this.tahunAnggota.Name = "tahunAnggota";
            this.tahunAnggota.Size = new System.Drawing.Size(122, 13);
            this.tahunAnggota.TabIndex = 16;
            this.tahunAnggota.Text = "TahunBergabung Admin";
            this.tahunAnggota.Click += new System.EventHandler(this.tahunAnggota_Click);
            // 
            // asalKota
            // 
            this.asalKota.AutoSize = true;
            this.asalKota.Location = new System.Drawing.Point(38, 91);
            this.asalKota.Name = "asalKota";
            this.asalKota.Size = new System.Drawing.Size(81, 13);
            this.asalKota.TabIndex = 15;
            this.asalKota.Text = "AsalKota Admin";
            // 
            // idanggota
            // 
            this.idanggota.AutoSize = true;
            this.idanggota.Location = new System.Drawing.Point(38, 30);
            this.idanggota.Name = "idanggota";
            this.idanggota.Size = new System.Drawing.Size(48, 13);
            this.idanggota.TabIndex = 14;
            this.idanggota.Text = "Id Admin";
            // 
            // namaAnggota
            // 
            this.namaAnggota.AutoSize = true;
            this.namaAnggota.Location = new System.Drawing.Point(38, 61);
            this.namaAnggota.Name = "namaAnggota";
            this.namaAnggota.Size = new System.Drawing.Size(67, 13);
            this.namaAnggota.TabIndex = 13;
            this.namaAnggota.Text = "Nama Admin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "NomorTelepon Admin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAplikasiDataGridViewTextBoxColumn,
            this.idAdminDataGridViewTextBoxColumn,
            this.namaAdminDataGridViewTextBoxColumn,
            this.asalKotaAdminDataGridViewTextBoxColumn,
            this.nomorTeleponAdminDataGridViewTextBoxColumn,
            this.tahunBergabungAdminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataAdminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // execrudDataSet1
            // 
            this.execrudDataSet1.DataSetName = "execrudDataSet1";
            this.execrudDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataAdminBindingSource
            // 
            this.dataAdminBindingSource.DataMember = "dataAdmin";
            this.dataAdminBindingSource.DataSource = this.execrudDataSet1;
            // 
            // dataAdminTableAdapter
            // 
            this.dataAdminTableAdapter.ClearBeforeFill = true;
            // 
            // idAplikasiDataGridViewTextBoxColumn
            // 
            this.idAplikasiDataGridViewTextBoxColumn.DataPropertyName = "Id_Aplikasi";
            this.idAplikasiDataGridViewTextBoxColumn.HeaderText = "Id_Aplikasi";
            this.idAplikasiDataGridViewTextBoxColumn.Name = "idAplikasiDataGridViewTextBoxColumn";
            // 
            // idAdminDataGridViewTextBoxColumn
            // 
            this.idAdminDataGridViewTextBoxColumn.DataPropertyName = "Id_Admin";
            this.idAdminDataGridViewTextBoxColumn.HeaderText = "Id_Admin";
            this.idAdminDataGridViewTextBoxColumn.Name = "idAdminDataGridViewTextBoxColumn";
            // 
            // namaAdminDataGridViewTextBoxColumn
            // 
            this.namaAdminDataGridViewTextBoxColumn.DataPropertyName = "Nama_Admin";
            this.namaAdminDataGridViewTextBoxColumn.HeaderText = "Nama_Admin";
            this.namaAdminDataGridViewTextBoxColumn.Name = "namaAdminDataGridViewTextBoxColumn";
            // 
            // asalKotaAdminDataGridViewTextBoxColumn
            // 
            this.asalKotaAdminDataGridViewTextBoxColumn.DataPropertyName = "AsalKota_Admin";
            this.asalKotaAdminDataGridViewTextBoxColumn.HeaderText = "AsalKota_Admin";
            this.asalKotaAdminDataGridViewTextBoxColumn.Name = "asalKotaAdminDataGridViewTextBoxColumn";
            // 
            // nomorTeleponAdminDataGridViewTextBoxColumn
            // 
            this.nomorTeleponAdminDataGridViewTextBoxColumn.DataPropertyName = "NomorTelepon_Admin";
            this.nomorTeleponAdminDataGridViewTextBoxColumn.HeaderText = "NomorTelepon_Admin";
            this.nomorTeleponAdminDataGridViewTextBoxColumn.Name = "nomorTeleponAdminDataGridViewTextBoxColumn";
            // 
            // tahunBergabungAdminDataGridViewTextBoxColumn
            // 
            this.tahunBergabungAdminDataGridViewTextBoxColumn.DataPropertyName = "TahunBergabung_Admin";
            this.tahunBergabungAdminDataGridViewTextBoxColumn.HeaderText = "TahunBergabung_Admin";
            this.tahunBergabungAdminDataGridViewTextBoxColumn.Name = "tahunBergabungAdminDataGridViewTextBoxColumn";
            // 
            // HalamanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxtahun);
            this.Controls.Add(this.textBoxaskot);
            this.Controls.Add(this.textBoxnama);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tahunAnggota);
            this.Controls.Add(this.asalKota);
            this.Controls.Add(this.idanggota);
            this.Controls.Add(this.namaAnggota);
            this.Controls.Add(this.backbut);
            this.Name = "HalamanAdmin";
            this.Text = "HalamanAdmin";
            this.Load += new System.EventHandler(this.HalamanAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbut;
        private System.Windows.Forms.TextBox textBoxtahun;
        private System.Windows.Forms.TextBox textBoxaskot;
        private System.Windows.Forms.TextBox textBoxnama;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label tahunAnggota;
        private System.Windows.Forms.Label asalKota;
        private System.Windows.Forms.Label idanggota;
        private System.Windows.Forms.Label namaAnggota;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private execrudDataSet1 execrudDataSet1;
        private System.Windows.Forms.BindingSource dataAdminBindingSource;
        private execrudDataSet1TableAdapters.dataAdminTableAdapter dataAdminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAplikasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asalKotaAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorTeleponAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunBergabungAdminDataGridViewTextBoxColumn;
    }
}