using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class ViewAdmin : Form
    {
        public ViewAdmin()
        {
            InitializeComponent();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            ViewADNguoiDung f = new ViewADNguoiDung();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLyHeThong_Click(object sender, EventArgs e)
        {
            ViewADHeThong f = new ViewADHeThong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
