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
    public partial class Halaman2 : Form
    {
        public Halaman2()
        {
            InitializeComponent();
        }

        private void adminbut_Click(object sender, EventArgs e)
        {
            HalamanAdmin admin = new HalamanAdmin();
            admin.Show();
            this.Hide();
        }

        private void anggotabut_Click(object sender, EventArgs e)
        {
          

            HalamanAnggota anggota = new HalamanAnggota();
            anggota.Show();
     this.Hide();
        }

        private void bukubut_Click(object sender, EventArgs e)
        {
            HalamanBuku buku = new HalamanBuku();
            buku.Show();
            this.Hide();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            HalamanAwal awal = new HalamanAwal();
            awal.Show();
            this.Hide();
        }

        private void Halaman2_Load(object sender, EventArgs e)
        {

        }
    }
}
