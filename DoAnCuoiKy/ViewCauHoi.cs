using DoAnCuoiKy.Model;
using System.Linq;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class ViewCauHoi : Form
    {
        public ViewCauHoi()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            using (var db = new LTUDQL1DataContext())
            {
                dgv_CauHoi.DataSource = db.CauHois.Select(u => u);
            }
        }

        private void dgv_CauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_CauHoi.SelectedRows.Count == 0)
            {
                return;
            }
            var dgvr = dgv_CauHoi.SelectedRows[0];
            txtMaCH.Text = dgvr.Cells["MaCH"].Value as string;
            txtCaphoc.Text = dgvr.Cells["CapHoc"].Value as string;
            txtMH.Text = dgvr.Cells["MonHoc"].Value as string;
            txtND.Text = dgvr.Cells["NoiDung"].Value as string;
            txtDAA.Text = dgvr.Cells["DapAnA"].Value as string;
            txtDAB.Text = dgvr.Cells["DapAnB"].Value as string;
            txtDAC.Text = dgvr.Cells["DapAnC"].Value as string;
            txtDAD.Text = dgvr.Cells["DapAnD"].Value as string;
            txtDA.Text = dgvr.Cells["DapAnDung"].Value as string;
        }

        private void btn_Sua_Click(object sender, System.EventArgs e)
        {
            LTUDQL1DataContext themCauHoi = new LTUDQL1DataContext();
            CauHoi ch = new CauHoi();
            ch = themCauHoi.CauHois.Where(u => u.MaCH == txtMaCH.Text).Single();
            ch.MaCH = txtMaCH.Text;
            ch.CapHoc = txtCaphoc.Text;
            ch.MonHoc = txtMH.Text;
            ch.NoiDung = txtND.Text;
            ch.DapAnA = txtDAA.Text;
            ch.DapAnB = txtDAB.Text;
            ch.DapAnC = txtDAC.Text;
            ch.DapAnD = txtDAD.Text;
            ch.DapAnDung = txtDA.Text;

            themCauHoi.SubmitChanges();
            LoadData();
            MessageBox.Show("Update success!!!");
            CleanTextBox();
        }

        private void CleanTextBox()
        {
            txtMaCH.Text = "";
            txtCaphoc.Text = "";
            txtMH.Text = "";
            txtND.Text = "";
            txtDAA.Text = "";
            txtDAB.Text = "";
            txtDAC.Text = "";
            txtDAD.Text = "";
            txtDA.Text = "";
        }
    }
}
