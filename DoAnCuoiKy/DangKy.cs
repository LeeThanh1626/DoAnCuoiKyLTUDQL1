using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            var hoten = txtHoTen.Text;
            var maso = txtMaSo.Text;
            var email = txtEmail.Text;
            var ngaysinh = datengaysinh.Text;
            var gioitinh = cbbGioiTinh.Text;
            var phone = txtPhone.Text;
            var tendangnhap = txttendangnhap.Text;
            var matkhau = txtmatkhau.Text;
            var phanquyen = int.Parse(cbbPhanQuyen.Text.ToString());
      
            using (var db = new LTUDQL1DataContext())
            {
                if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap) != null)
                {
                    MessageBox.Show("User đã tồn tại!");
                    return;
                }
                db.USERs.InsertOnSubmit(new USER
                {
                    f_HoTen = hoten,
                    f_MaSo = maso,
                    f_Email = email,
                    f_GioiTinh = gioitinh,
                    f_MatKhau = matkhau,
                    f_NgaySinh = ngaysinh,
                    f_Phone = phone,
                    f_TenDangNhap = tendangnhap,
                    f_IDPhanQuyen = phanquyen
                });
                db.SubmitChanges();
               
            }



            if (txtmatkhau.Text == txtxacnhanmatkhau.Text)
            {
                MessageBox.Show("Đăng ký thành công!");
            }
            else if (txtxacnhanmatkhau.Text != txtmatkhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng!");
                txtxacnhanmatkhau.Focus();
                txtxacnhanmatkhau.SelectAll();
            }

        }

        ErrorProvider ErrorProvider = new ErrorProvider();
        private void Exit_Click(object sender, EventArgs e)
        {

            new DangNhap().ShowDialog();
            this.Hide();
        }

        private void txttendangnhap_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.Match(txttendangnhap.Text, @"(^[a-z][a-z1-9-._]+$)").Success != true)
            {
                ErrorProvider.SetError(txttendangnhap, "Phải bắt đầu bằng ký tự từ a-z \n Không khoảng trắng \n Không ký tự đặc biệt");
                e.Cancel = true;
            }
            else
            {
                ErrorProvider.SetError(txttendangnhap, "");
            }
        }

        private void txtmatkhau_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.Match(txtmatkhau.Text, @"^[a-z1-9]{3,}$").Success != true)
            {
                ErrorProvider.SetError(txtmatkhau, "Tối thiểu 3 ký tự \n Chỉ gồm a-z và 1-9");
                e.Cancel = true;
            }
            else
            {
                ErrorProvider.SetError(txtmatkhau, "");
            }
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.Match(txtHoTen.Text, @"^[a-zA-Z]+$").Success != true)
            {
                ErrorProvider.SetError(txtHoTen, "Tên chỉ chứa a-z và A-Z");
                e.Cancel = true;
            }
            else
            {
                ErrorProvider.SetError(txtHoTen, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.Match(txtEmail.Text, @"^[a-z1-9A-Z\-\.]+\@([a-z1-9A-Z\-]+\.)+[a-z1-9A-Z]{2,}$").Success != true)
            {
                ErrorProvider.SetError(txtEmail, "Nhập Mail hợp lệ \n Example123@gmail.com \n Hay: Example2@student.hcmus.edu.vn");
                e.Cancel = true;
            }
            else
            {
                ErrorProvider.SetError(txtEmail, "");
            }
        }

        private void datengaysinh_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.Match(datengaysinh.Text, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](\d){4}$").Success != true)
            {
                ErrorProvider.SetError(datengaysinh, "Nhập ngày hợp lệ dd/mm/yyy \n Example: 01/12/2020");
                e.Cancel = true;
            }
            else
            {
                ErrorProvider.SetError(datengaysinh, "");
            }
        }
    }
}
