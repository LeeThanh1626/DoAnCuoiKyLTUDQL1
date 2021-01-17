using DoAnCuoiKy.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class ViewHocSinh : Form
    {
        BindingSource bsCR;
        ReportDataSource rdsCR;
        public ViewHocSinh()
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
                dgv_HocVien.DataSource = db.KetQuas.Select(u => u);
            }
        }
        private void ViewHocSinh_Load(object sender, EventArgs e)
        {

            this.rpv_HocSinh.RefreshReport();
        }

        private void rpv_HocSinh_Load(object sender, EventArgs e)
        {
            rpv_HocSinh.LocalReport.DataSources.Clear();
            using (var db = new LTUDQL1DataContext())
            {
                bsCR.DataSource = from kq in db.KetQuas
                                  join kt in db.KyThis on new { kq.MaKT, kq.MaHV }
                                  equals new { kt.MaKT, kt.MaHV }
                                  join dt in db.DeThis on kt.MaDT equals dt.MaDT
                                  join ch in db.CauHois on dt.MaCH equals ch.MaCH
                                  select new KetQuaRP { MaHocVien = kq.MaHV, Diem = kq.Diem, KyThi = kt.MaKT, CauHoi = ch.MaCH };
            }
            rdsCR.Value = bsCR;
            rdsCR.Name = "DataSetHV";
            rpv_HocSinh.LocalReport.DataSources.Add(rdsCR);
        }

        private void btn_LoadReport_Click(object sender, EventArgs e)
        {
            string ky = txtChonKy.Text;
            using (var db = new LTUDQL1DataContext())
            {
                bsCR.DataSource = from kq in db.KetQuas
                                  join kt in db.KyThis on new { kq.MaKT, kq.MaHV }
                                  equals new { kt.MaKT, kt.MaHV }
                                  join dt in db.DeThis on kt.MaDT equals dt.MaDT
                                  join ch in db.CauHois on dt.MaCH equals ch.MaCH
                                  where kq.MaKT == ky
                                  select new KetQuaRP { MaHocVien = kq.MaHV, Diem = kq.Diem, KyThi = kt.MaKT, CauHoi = ch.MaCH };
            }
            this.rpv_HocSinh.RefreshReport();
        }

        private void btn_RPCauhoi_Click(object sender, EventArgs e)
        {
            string cauhoi = txtRPCauHoi.Text;
            using (var db = new LTUDQL1DataContext())
            {
                bsCR.DataSource = from kq in db.KetQuas
                                  join kt in db.KyThis on new { kq.MaKT, kq.MaHV }
                                  equals new { kt.MaKT, kt.MaHV }
                                  join dt in db.DeThis on kt.MaDT equals dt.MaDT
                                  join ch in db.CauHois on dt.MaCH equals ch.MaCH
                                  where ch.MaCH == cauhoi
                                  select new KetQuaRP { MaHocVien = kq.MaHV, Diem = kq.Diem, KyThi = kt.MaKT, CauHoi = ch.MaCH };
            }
            this.rpv_HocSinh.RefreshReport();
        }
    }
}
