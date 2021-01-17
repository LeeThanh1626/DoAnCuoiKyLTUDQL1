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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace DoAnCuoiKy
{
    
    public partial class ViewKyThi : Form
    {
        BindingSource bsCR;
        ReportDataSource rdsCR;
        public ViewKyThi()
        {
            InitializeComponent();
            LoadData();
            bsCR = new BindingSource();
            rdsCR = new ReportDataSource();
        }

        private void LoadData()
        {
            using (var db = new LTUDQL1DataContext())
            {
                dgv_KyThi.DataSource = db.KyThis.Select(u => u);
            }
        }

        private void KyThi_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
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

        private void btn_TaoKyThi_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext themkt = new LTUDQL1DataContext();
            KyThi kt = new KyThi();
            kt.MaKT = txtmakt.Text;
            kt.Ngay = txtmant.Text;
            kt.MaDT = txtmadt.Text;
            kt.ThoiGian = txttg.Text;
            kt.MaHV = txtmahv.Text;

            if (kt.MaKT == "" && kt.MaHV == "")
            {
                MessageBox.Show("Không được bỏ trống Mã Kỳ Thi và Mã Học Viên!!!");
                return;
            }
            else
            {
                themkt.KyThis.InsertOnSubmit(kt);
                themkt.SubmitChanges();
                MessageBox.Show("Tạo thành công kỳ thi thử!!!");
                LoadData();
            }

            CleanTextBox();
        }

        private void CleanTextBox()
        {
            txtmakt.Text = "";
            txtmadt.Text = "";
            txtmahv.Text = "";
            txtmant.Text = "";
            txttg.Text = "";
        }

        private void btn_SuaKT_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext suakt = new LTUDQL1DataContext();
            KyThi kt = new KyThi();
            kt = suakt.KyThis.Where(u => u.MaKT == txtmakt.Text).Where(u=> u.MaHV == txtmahv.Text).Single();
            kt.MaKT = txtmakt.Text;
            kt.Ngay = txtmant.Text;
            kt.MaDT = txtmadt.Text;
            kt.ThoiGian = txttg.Text;
            kt.MaHV = txtmahv.Text;

            suakt.SubmitChanges();
            MessageBox.Show("UpDate thành công!!!");
            LoadData();
            CleanTextBox();

        }

        private void btn_XoaKT_Click(object sender, EventArgs e)
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
            MessageBox.Show("Xóa thành công!!!");
            LoadData();
            CleanTextBox();
        }

        private void btn_LoadReport_Click(object sender, EventArgs e)
        {
            string ky = txtChonKy.Text;
            using (var db = new LTUDQL1DataContext())
            {
                bsCR.DataSource = from kq in db.KetQuas
                                  join kt in db.KyThis on new { kq.MaKT, kq.MaHV }
                                  equals new { kt.MaKT, kt.MaHV }
                                  join sv in db.USERs on kt.MaHV equals sv.f_MaSo
                                  where kt.MaKT == ky
                                  select new ThiSinhRP
                                  {
                                      MaKyThi = kt.MaKT,
                                      MaHocVien = sv.f_MaSo,
                                      TenHocVien = sv.f_HoTen,
                                      NgaySinh = sv.f_NgaySinh,
                                      GioiTinh = sv.f_GioiTinh,
                                      Diem = kq.Diem
                                  };
            }
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            using (var db = new LTUDQL1DataContext())
            {
                bsCR.DataSource = from kq in db.KetQuas
                                  join kt in db.KyThis on new { kq.MaKT, kq.MaHV }
                                  equals new { kt.MaKT, kt.MaHV }
                                  join sv in db.USERs on kt.MaHV equals sv.f_MaSo
                                  select new ThiSinhRP {MaKyThi = kt.MaKT, MaHocVien = sv.f_MaSo,
                                                        TenHocVien = sv.f_HoTen, NgaySinh = sv.f_NgaySinh,
                                                        GioiTinh = sv.f_GioiTinh, Diem = kq.Diem};
            }
            rdsCR.Value = bsCR;
            rdsCR.Name = "RPTheoKy";
            reportViewer1.LocalReport.DataSources.Add(rdsCR);
        }

        private void ViewKyThi_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

    }
}
