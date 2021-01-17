using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClosedXML;
using DoAnCuoiKy;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy  
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
            var tendangnhap = txtUsername.Text;
            var matkhau = txtPassword.Text;

            using (var db = new LTUDQL1DataContext())
            {
                if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau && u.f_IDPhanQuyen == 0)  != null)
                {
                    MessageBox.Show("LOGIN ADMIN");
                    ViewAdmin f = new ViewAdmin();
                    this.Hide();
                    f.ShowDialog();
                    
                }
                else if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau && u.f_IDPhanQuyen == 2) != null)
                {
                    MessageBox.Show("LOGIN GIÁO VIÊN");
                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                }
                else if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau && u.f_IDPhanQuyen == 1) != null)
                {
                    MessageBox.Show("LOGIN HỌC SINH");
                    Form2 f = new Form2();
                    this.Hide();
                    f.ShowDialog();
                    
                }

            }


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
        private void dangky_Click(object sender, EventArgs e)
        {
            
            new DangKy().Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }

       
    }
}
