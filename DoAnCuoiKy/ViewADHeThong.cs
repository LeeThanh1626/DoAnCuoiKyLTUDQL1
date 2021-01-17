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
    public partial class ViewADHeThong : Form
    {
        public ViewADHeThong()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            ViewADBackUp f = new ViewADBackUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            ViewADRestore f = new ViewADRestore();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
