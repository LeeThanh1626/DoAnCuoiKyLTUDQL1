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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_qlchoi_Click(object sender, EventArgs e)
        {
            ViewCauHoi cauhoi = new ViewCauHoi();
            cauhoi.Show();
        }

        private void btn_qldthi_Click(object sender, EventArgs e)
        {
            ViewDeThi dethi = new ViewDeThi();
            dethi.Show();
        }

        private void btn_qlhsinh_Click(object sender, EventArgs e)
        {
            ViewHocSinh hs = new ViewHocSinh();
            hs.Show();
        }

        private void btn_qlkthi_Click(object sender, EventArgs e)
        {
            ViewKyThi kythi = new ViewKyThi();
            kythi.Show();
        }

        private void btn_qltthu_Click(object sender, EventArgs e)
        {
            ViewThiThu thithu = new ViewThiThu();
            thithu.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
