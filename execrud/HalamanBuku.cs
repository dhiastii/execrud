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
    public partial class HalamanBuku : Form
    {
        public HalamanBuku()
        {
            InitializeComponent();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            Halaman2 hal2 = new Halaman2();
            hal2.Show();
            this.Hide();
        }

        private void HalamanBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'execrudDataSet2.dataBuku' table. You can move, or remove it, as needed.
            this.dataBukuTableAdapter.Fill(this.execrudDataSet2.dataBuku);

        }
    }
}
