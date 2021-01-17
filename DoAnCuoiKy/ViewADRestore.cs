using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
    public partial class ViewADRestore : Form
    {
        public ViewADRestore()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                Server dbserver = new Server(new ServerConnection(txtServer.Text));
                Restore dbrestore = new Restore() { Database = txtDB.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbrestore.Devices.AddDevice(@"C:\Data\LTUDQL1.txt", DeviceType.File);
                dbrestore.Complete += Dbrestore_Complete;
                dbrestore.PercentComplete += Dbrestore_PercentComplete;
                dbrestore.SqlRestoreAsync(dbserver);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dbrestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lbPercent.Invoke((MethodInvoker)delegate
            {
                lbPercent.Text = $"{e.Percent}%";
            });
        }

        private void Dbrestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lbStatus.Invoke((MethodInvoker)delegate
                {
                    lbStatus.Text = e.Error.Message;

                });
            }
        }
    }
}
