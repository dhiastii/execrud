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
    public partial class HalamanAdmin : Form
    {
        public HalamanAdmin()
        {
            InitializeComponent();
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            Halaman2 hal2 = new Halaman2();
            hal2.Show();
            this.Hide();
        }

        private void tahunAnggota_Click(object sender, EventArgs e)
        {

        }

        private void HalamanAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'execrudDataSet1.dataAdmin' table. You can move, or remove it, as needed.
            this.dataAdminTableAdapter.Fill(this.execrudDataSet1.dataAdmin);

        }
    }
}
