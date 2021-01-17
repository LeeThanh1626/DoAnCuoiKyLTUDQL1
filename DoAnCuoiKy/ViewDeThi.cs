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
    public partial class ViewDeThi : Form
    {
        public ViewDeThi()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new LTUDQL1DataContext())
            {
                dgv_DeThi.DataSource = db.DeThis.Select(u => u);
            }
        }

        private void dgv_DeThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_DeThi.SelectedRows.Count == 0)
            {
                return;
            }
            var dgvr = dgv_DeThi.SelectedRows[0];
            txtMaCH.Text = dgvr.Cells["MaCH"].Value as string;
            txtMaDT.Text = dgvr.Cells["MaDT"].Value as string;
            txtMaBD.Text = dgvr.Cells["MaBD"].Value as string;
            txtMaDK.Text = dgvr.Cells["MaDK"].Value as string;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext themdt = new LTUDQL1DataContext();
            DeThi dt = new DeThi();

            dt.MaDT = txtMaDT.Text;
            dt.MaBD = txtMaBD.Text;
            dt.MaCH = txtMaCH.Text;
            dt.MaDK = txtMaDK.Text;

            if (dt.MaDK == "" && dt.MaDT == "")
            {
                MessageBox.Show("Insert Fail!!!");
                return;
            }
            themdt.DeThis.InsertOnSubmit(dt);
            themdt.SubmitChanges();
            MessageBox.Show("Insert Success!!!");
            LoadData();
            CleanTextBox();

        }

        private void CleanTextBox()
        {
            txtMaDT.Text = "";
            txtMaBD.Text = "";
            txtMaCH.Text = "";
            txtMaDK.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext xoadt = new LTUDQL1DataContext();
            DeThi dt = new DeThi();
            dt = xoadt.DeThis.Where(u => u.MaDK == txtMaDK.Text).Where(u => u.MaDT == txtMaDT.Text).Single();

            dt.MaDT = txtMaDT.Text;
            dt.MaBD = txtMaBD.Text;
            dt.MaCH = txtMaCH.Text;
            dt.MaDK = txtMaDK.Text;

            xoadt.DeThis.DeleteOnSubmit(dt);
            xoadt.SubmitChanges();
            MessageBox.Show("Delete Success!!!");
            LoadData();
            CleanTextBox();


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            LTUDQL1DataContext Suadt = new LTUDQL1DataContext();
            DeThi dt = new DeThi();
            dt = Suadt.DeThis.Where(u => u.MaDK == txtMaDK.Text).Where(u => u.MaDT == txtMaDT.Text).Single();

            dt.MaDT = txtMaDT.Text;
            dt.MaBD = txtMaBD.Text;
            dt.MaCH = txtMaCH.Text;
            dt.MaDK = txtMaDK.Text;

            Suadt.SubmitChanges();
            MessageBox.Show("Update Success!!!");
            LoadData();
            CleanTextBox();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
