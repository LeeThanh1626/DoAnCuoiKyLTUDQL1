using DoAnCuoiKy.Model;
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
    public partial class ViewThiThu : Form
    {
        public ViewThiThu()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new LTUDQL1DataContext())
            {
                dgv_KyThi.DataSource = db.KyThis.Select(u => u);
            }
        }

        private void CleanTextBox()
        {
            txtmakt.Text = "";
            txtmadt.Text = "";
            txtmahv.Text = "";
            txtmant.Text = "";
            txttg.Text = "";
        }
        private void dgv_KyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_KyThi.SelectedRows.Count == 0)
            {
                return;
            }
            var dgvr = dgv_KyThi.SelectedRows[0];
            txtmahv.Text = dgvr.Cells["MaHV"].Value as string;
            txtmakt.Text = dgvr.Cells["MaKT"].Value as string;
            txtmadt.Text = dgvr.Cells["MaDT"].Value as string;
            txtmant.Text = dgvr.Cells["Ngay"].Value as string;
            txttg.Text = dgvr.Cells["ThoiGian"].Value as string;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext xoakt = new LTUDQL1DataContext();
            KyThi kt = new KyThi();
            kt = xoakt.KyThis.Where(u => u.MaKT == txtmakt.Text).Where(u => u.MaHV == txtmahv.Text).Single();
            kt.MaKT = txtmakt.Text;
            kt.Ngay = txtmant.Text;
            kt.MaDT = txtmadt.Text;
            kt.ThoiGian = txttg.Text;
            kt.MaHV = txtmahv.Text;

            xoakt.KyThis.DeleteOnSubmit(kt);
            xoakt.SubmitChanges();
            LoadData();
            MessageBox.Show("Xóa thành công!!!");
            CleanTextBox();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            LTUDQL1DataContext themkt = new LTUDQL1DataContext();
            KyThi kt = new KyThi();
            kt.MaKT = txtmakt.Text;
            kt.Ngay = txtmant.Text;
            kt.MaDT = txtmadt.Text;
            kt.ThoiGian = txttg.Text;
            kt.MaHV = txtmahv.Text;
            if(kt.MaKT == "" && kt.MaHV == "")
            {
                MessageBox.Show("Không được bỏ trống Mã Kỳ Thi và Mã Học Viên!!!");
                return;
            }
            else
            {
                themkt.KyThis.InsertOnSubmit(kt);
                themkt.SubmitChanges();
                LoadData();
                MessageBox.Show("Tạo thành công kỳ thi thử!!!");
                CleanTextBox();
            }

            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext suakt = new LTUDQL1DataContext();
            KyThi kt = new KyThi();
            kt = suakt.KyThis.Where(u => u.MaKT == txtmakt.Text).Where(u => u.MaHV == txtmahv.Text).Single();
            kt.MaKT = txtmakt.Text;
            kt.Ngay = txtmant.Text;
            kt.MaDT = txtmadt.Text;
            kt.ThoiGian = txttg.Text;
            kt.MaHV = txtmahv.Text;

            suakt.SubmitChanges();
            LoadData();
            MessageBox.Show("UpDate thành công!!!");
            CleanTextBox();

        }
    }
}
