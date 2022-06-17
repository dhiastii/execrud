using System;

namespace execrud
{
    partial class HalamanAnggota
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
            this.dataAnggotaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.execrudDataSet3 = new execrud.execrudDataSet3();
            this.dataAnggotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.execrudDataSet = new execrud.execrudDataSet();
            this.dataAnggotaTableAdapter = new execrud.execrudDataSetTableAdapters.dataAnggotaTableAdapter();
            this.namaAnggota = new System.Windows.Forms.Label();
            this.idanggota = new System.Windows.Forms.Label();
            this.asalKota = new System.Windows.Forms.Label();
            this.tahunAnggota = new System.Windows.Forms.Label();
            this.deletebut = new System.Windows.Forms.Button();
            this.editbut = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxnama = new System.Windows.Forms.TextBox();
            this.textBoxaskot = new System.Windows.Forms.TextBox();
            this.textBoxtahun = new System.Windows.Forms.TextBox();
            this.addbut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.execrudDataSet4 = new execrud.execrudDataSet4();
            this.dataAnggotaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAnggotaTableAdapter1 = new execrud.execrudDataSet4TableAdapters.dataAnggotaTableAdapter();
            this.idAplikasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaAnggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asalKotaAnggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunBergabungAnggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnggotaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnggotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnggotaBindingSource2)).BeginInit();
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
            // dataAnggotaBindingSource1
            // 
            this.dataAnggotaBindingSource1.DataMember = "dataAnggota";
            this.dataAnggotaBindingSource1.DataSource = this.execrudDataSet3;
            // 
            // execrudDataSet3
            // 
            this.execrudDataSet3.DataSetName = "execrudDataSet3";
            this.execrudDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataAnggotaBindingSource
            // 
            this.dataAnggotaBindingSource.DataMember = "dataAnggota";
            this.dataAnggotaBindingSource.DataSource = this.execrudDataSet;
            // 
            // execrudDataSet
            // 
            this.execrudDataSet.DataSetName = "execrudDataSet";
            this.execrudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataAnggotaTableAdapter
            // 
            this.dataAnggotaTableAdapter.ClearBeforeFill = true;
            // 
            // namaAnggota
            // 
            this.namaAnggota.AutoSize = true;
            this.namaAnggota.Location = new System.Drawing.Point(45, 66);
            this.namaAnggota.Name = "namaAnggota";
            this.namaAnggota.Size = new System.Drawing.Size(78, 13);
            this.namaAnggota.TabIndex = 2;
            this.namaAnggota.Text = "Nama Anggota";
            // 
            // idanggota
            // 
            this.idanggota.AutoSize = true;
            this.idanggota.Location = new System.Drawing.Point(45, 35);
            this.idanggota.Name = "idanggota";
            this.idanggota.Size = new System.Drawing.Size(59, 13);
            this.idanggota.TabIndex = 3;
            this.idanggota.Text = "Id Anggota";
            // 
            // asalKota
            // 
            this.asalKota.AutoSize = true;
            this.asalKota.Location = new System.Drawing.Point(45, 96);
            this.asalKota.Name = "asalKota";
            this.asalKota.Size = new System.Drawing.Size(92, 13);
            this.asalKota.TabIndex = 4;
            this.asalKota.Text = "AsalKota Anggota";
            // 
            // tahunAnggota
            // 
            this.tahunAnggota.AutoSize = true;
            this.tahunAnggota.Location = new System.Drawing.Point(45, 126);
            this.tahunAnggota.Name = "tahunAnggota";
            this.tahunAnggota.Size = new System.Drawing.Size(133, 13);
            this.tahunAnggota.TabIndex = 5;
            this.tahunAnggota.Text = "TahunBergabung Anggota";
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(185, 162);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(75, 23);
            this.deletebut.TabIndex = 7;
            this.deletebut.Text = "Hapus";
            this.deletebut.UseVisualStyleBackColor = true;
            // 
            // editbut
            // 
            this.editbut.Location = new System.Drawing.Point(327, 162);
            this.editbut.Name = "editbut";
            this.editbut.Size = new System.Drawing.Size(75, 23);
            this.editbut.TabIndex = 8;
            this.editbut.Text = "Edit";
            this.editbut.UseVisualStyleBackColor = true;
            this.editbut.Click += new System.EventHandler(this.editbut_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAnggotaBindingSource, "Id_Anggota", true));
            this.textBoxid.Location = new System.Drawing.Point(196, 32);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(137, 20);
            this.textBoxid.TabIndex = 9;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBoxid_Text);
            // 
            // textBoxnama
            // 
            this.textBoxnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAnggotaBindingSource, "Nama_Anggota", true));
            this.textBoxnama.Location = new System.Drawing.Point(196, 63);
            this.textBoxnama.Name = "textBoxnama";
            this.textBoxnama.Size = new System.Drawing.Size(211, 20);
            this.textBoxnama.TabIndex = 10;
            // 
            // textBoxaskot
            // 
            this.textBoxaskot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAnggotaBindingSource, "AsalKota_Anggota", true));
            this.textBoxaskot.Location = new System.Drawing.Point(196, 93);
            this.textBoxaskot.Name = "textBoxaskot";
            this.textBoxaskot.Size = new System.Drawing.Size(211, 20);
            this.textBoxaskot.TabIndex = 11;
            // 
            // textBoxtahun
            // 
            this.textBoxtahun.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAnggotaBindingSource, "TahunBergabung_Anggota", true));
            this.textBoxtahun.Location = new System.Drawing.Point(196, 123);
            this.textBoxtahun.Name = "textBoxtahun";
            this.textBoxtahun.Size = new System.Drawing.Size(64, 20);
            this.textBoxtahun.TabIndex = 12;
            // 
            // addbut
            // 
            this.addbut.Location = new System.Drawing.Point(48, 161);
            this.addbut.Name = "addbut";
            this.addbut.Size = new System.Drawing.Size(75, 23);
            this.addbut.TabIndex = 13;
            this.addbut.Text = "Add";
            this.addbut.UseVisualStyleBackColor = true;
            this.addbut.Click += new System.EventHandler(this.addbut_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAplikasiDataGridViewTextBoxColumn,
            this.idAnggotaDataGridViewTextBoxColumn,
            this.namaAnggotaDataGridViewTextBoxColumn,
            this.asalKotaAnggotaDataGridViewTextBoxColumn,
            this.tahunBergabungAnggotaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataAnggotaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // execrudDataSet4
            // 
            this.execrudDataSet4.DataSetName = "execrudDataSet4";
            this.execrudDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataAnggotaBindingSource2
            // 
            this.dataAnggotaBindingSource2.DataMember = "dataAnggota";
            this.dataAnggotaBindingSource2.DataSource = this.execrudDataSet4;
            // 
            // dataAnggotaTableAdapter1
            // 
            this.dataAnggotaTableAdapter1.ClearBeforeFill = true;
            // 
            // idAplikasiDataGridViewTextBoxColumn
            // 
            this.idAplikasiDataGridViewTextBoxColumn.DataPropertyName = "Id_Aplikasi";
            this.idAplikasiDataGridViewTextBoxColumn.HeaderText = "Id_Aplikasi";
            this.idAplikasiDataGridViewTextBoxColumn.Name = "idAplikasiDataGridViewTextBoxColumn";
            // 
            // idAnggotaDataGridViewTextBoxColumn
            // 
            this.idAnggotaDataGridViewTextBoxColumn.DataPropertyName = "Id_Anggota";
            this.idAnggotaDataGridViewTextBoxColumn.HeaderText = "Id_Anggota";
            this.idAnggotaDataGridViewTextBoxColumn.Name = "idAnggotaDataGridViewTextBoxColumn";
            // 
            // namaAnggotaDataGridViewTextBoxColumn
            // 
            this.namaAnggotaDataGridViewTextBoxColumn.DataPropertyName = "Nama_Anggota";
            this.namaAnggotaDataGridViewTextBoxColumn.HeaderText = "Nama_Anggota";
            this.namaAnggotaDataGridViewTextBoxColumn.Name = "namaAnggotaDataGridViewTextBoxColumn";
            // 
            // asalKotaAnggotaDataGridViewTextBoxColumn
            // 
            this.asalKotaAnggotaDataGridViewTextBoxColumn.DataPropertyName = "AsalKota_Anggota";
            this.asalKotaAnggotaDataGridViewTextBoxColumn.HeaderText = "AsalKota_Anggota";
            this.asalKotaAnggotaDataGridViewTextBoxColumn.Name = "asalKotaAnggotaDataGridViewTextBoxColumn";
            // 
            // tahunBergabungAnggotaDataGridViewTextBoxColumn
            // 
            this.tahunBergabungAnggotaDataGridViewTextBoxColumn.DataPropertyName = "TahunBergabung_Anggota";
            this.tahunBergabungAnggotaDataGridViewTextBoxColumn.HeaderText = "TahunBergabung_Anggota";
            this.tahunBergabungAnggotaDataGridViewTextBoxColumn.Name = "tahunBergabungAnggotaDataGridViewTextBoxColumn";
            // 
            // HalamanAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addbut);
            this.Controls.Add(this.textBoxtahun);
            this.Controls.Add(this.textBoxaskot);
            this.Controls.Add(this.textBoxnama);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.editbut);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.tahunAnggota);
            this.Controls.Add(this.asalKota);
            this.Controls.Add(this.idanggota);
            this.Controls.Add(this.namaAnggota);
            this.Controls.Add(this.backbut);
            this.Name = "HalamanAnggota";
            this.Text = "HalamanAnggota";
            this.Load += new System.EventHandler(this.HalamanAnggota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAnggotaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnggotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execrudDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAnggotaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbut;
        private execrudDataSet execrudDataSet;
        private System.Windows.Forms.BindingSource dataAnggotaBindingSource;
        private execrudDataSetTableAdapters.dataAnggotaTableAdapter dataAnggotaTableAdapter;
        private System.Windows.Forms.Label namaAnggota;
        private System.Windows.Forms.Label idanggota;
        private System.Windows.Forms.Label asalKota;
        private System.Windows.Forms.Label tahunAnggota;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Button editbut;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxnama;
        private System.Windows.Forms.TextBox textBoxaskot;
        private System.Windows.Forms.TextBox textBoxtahun;
        private System.Windows.Forms.Button addbut;
        private EventHandler addbut_Click;
        private EventHandler editbut_click;
        private EventHandler deletebut_Click;
        private execrudDataSet3 execrudDataSet3;
        private System.Windows.Forms.BindingSource dataAnggotaBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private execrudDataSet4 execrudDataSet4;
        private System.Windows.Forms.BindingSource dataAnggotaBindingSource2;
        private execrudDataSet4TableAdapters.dataAnggotaTableAdapter dataAnggotaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAplikasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaAnggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asalKotaAnggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunBergabungAnggotaDataGridViewTextBoxColumn;
    }
}