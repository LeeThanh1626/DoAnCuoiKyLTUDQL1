using ClosedXML.Excel;
using DoAnCuoiKy.Model;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace DoAnCuoiKy
{
    public partial class ViewADNguoiDung : Form
    {

        public ViewADNguoiDung()
        {
            InitializeComponent();

            LoadData();

        }
        private void LoadData()
        {
            using (var db = new LTUDQL1DataContext())
            {
                dgv_NguoiDung.DataSource = db.USERs.Select(u => u);
            }
        }

     
        private void CleanTextBox()
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtMaSo.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtPhone.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtIDPhanQuyen.Text = "";
        }


        private void btnImEx_Click(object sender, EventArgs e)
        {
            ViewReportImport f = new ViewReportImport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            LTUDQL1DataContext themnd = new LTUDQL1DataContext();
            USER us = new USER();
            us.f_HoTen = txtHoTen.Text;
            us.f_MaSo = txtMaSo.Text;
            us.f_Email = txtEmail.Text;
            us.f_GioiTinh = txtGioiTinh.Text;
            us.f_NgaySinh = txtNgaySinh.Text;
            us.f_Phone = txtPhone.Text;
            us.f_TenDangNhap = txtTenDangNhap.Text;
            us.f_MatKhau = txtMatKhau.Text;
            us.f_IDPhanQuyen = int.Parse(txtIDPhanQuyen.Text.ToString());
            if (us.f_HoTen == "" && us.f_TenDangNhap == "" && us.f_MaSo == "" && us.f_Email == "" && us.f_NgaySinh == "" && us.f_MatKhau == "")
            {
                MessageBox.Show("Không được bỏ trống !!!");
                return;
            }
            else
            {
                themnd.USERs.InsertOnSubmit(us);
                themnd.SubmitChanges();
                MessageBox.Show("Tạo thành công người Dùng!!!");
                LoadData();
            }
            CleanTextBox();

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            LTUDQL1DataContext xoa = new LTUDQL1DataContext();
            USER us = new USER();
            us = xoa.USERs.Where(u => u.f_MaSo == txtMaSo.Text).Single();
            us.f_HoTen = txtHoTen.Text;
            us.f_Email = txtEmail.Text;
            us.f_GioiTinh = txtGioiTinh.Text;
            us.f_NgaySinh = txtNgaySinh.Text;
            us.f_Phone = txtPhone.Text;
            us.f_TenDangNhap = txtTenDangNhap.Text;
            us.f_MatKhau = txtMatKhau.Text;
            us.f_IDPhanQuyen = int.Parse(txtIDPhanQuyen.Text.ToString());

            xoa.USERs.DeleteOnSubmit(us);
            xoa.SubmitChanges();
            MessageBox.Show("Xóa thành công!!!");
            LoadData();
            CleanTextBox();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            LTUDQL1DataContext sua = new LTUDQL1DataContext();
            USER us = new USER();
            us = sua.USERs.Where(u => u.f_MaSo == txtMaSo.Text).Single();
            us.f_HoTen = txtHoTen.Text;
            us.f_Email = txtEmail.Text;
            us.f_GioiTinh = txtGioiTinh.Text;
            us.f_NgaySinh = txtNgaySinh.Text;
            us.f_Phone = txtPhone.Text;
            us.f_TenDangNhap = txtTenDangNhap.Text;
            us.f_MatKhau = txtMatKhau.Text;
            us.f_IDPhanQuyen = int.Parse(txtIDPhanQuyen.Text.ToString());

            sua.SubmitChanges();
            MessageBox.Show("UpDate thành công!!!");
            LoadData();
            CleanTextBox();
        }

        private void dgv_NguoiDung_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NguoiDung.SelectedRows.Count == 0)
            {
                return;
            }
            var dgvr = dgv_NguoiDung.SelectedRows[0];
            txtHoTen.Text = dgvr.Cells["f_HoTen"].Value as string;
            txtMaSo.Text = dgvr.Cells["f_MaSo"].Value as string;
            txtEmail.Text = dgvr.Cells["f_Email"].Value as string;
            txtGioiTinh.Text = dgvr.Cells["f_GioiTinh"].Value as string;
            txtNgaySinh.Text = dgvr.Cells["f_NgaySinh"].Value as string;
            txtPhone.Text = dgvr.Cells["f_Phone"].Value as string;
            txtTenDangNhap.Text = dgvr.Cells["f_TenDangNhap"].Value as string;
            txtMatKhau.Text = dgvr.Cells["f_MatKhau"].Value as string;
            txtIDPhanQuyen.Text = dgvr.Cells["f_IDPhanQuyen"].Value.ToString();
        }
    }
}
