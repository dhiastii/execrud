using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace execrud
{
    public partial class HalamanAnggota : Form
    {
        public HalamanAnggota()
        {
            InitializeComponent();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            Halaman2 hal2 = new Halaman2();
            hal2.Show();
            this.Hide();
        }

        private void tahun_Click(object sender, EventArgs e)
        {

        }

        private void addbut_Click_1(object sender, EventArgs e)
        {

        }

        private void HalamanAnggota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'execrudDataSet4.dataAnggota' table. You can move, or remove it, as needed.
            this.dataAnggotaTableAdapter1.Fill(this.execrudDataSet4.dataAnggota);
            // TODO: This line of code loads data into the 'execrudDataSet3.dataAnggota' table. You can move, or remove it, as needed.
            //this.dataAnggotaTableAdapter1.Fill(this.execrudDataSet3.dataAnggota);

        }

        private void deletebut_Click_1(object sender, EventArgs e)
        {

        }

        private void editbut_Click(object sender, EventArgs e)
        {
        
        }

        private void textBoxid_Text(object sender, EventArgs e)
        {
        
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
