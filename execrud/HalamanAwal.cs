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
    public partial class HalamanAwal : Form
    {
        public HalamanAwal()
        {
            InitializeComponent();
        }

        private void startbut_Click(object sender, EventArgs e)
        {
            Halaman2 hal2 = new Halaman2();
            hal2.Show();
            this.Hide();
        }
    }
}
