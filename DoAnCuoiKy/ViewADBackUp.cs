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
    public partial class ViewADBackUp : Form
    {
        public ViewADBackUp()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                Server dbserver = new Server(new ServerConnection(txtServer.Text));
                Backup dbbackup = new Backup() { Action = BackupActionType.Database, Database = txtDB.Text };
                dbbackup.Devices.AddDevice(@"C:\Data\LTUDQL1.bak", DeviceType.File);
                dbbackup.Initialize = true;
                dbbackup.PercentComplete += Dbbackup_PercentComplete;
                dbbackup.Complete += Dbbackup_Complete;
                dbbackup.SqlBackupAsync(dbserver);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dbbackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error != null)
            {
                lbStatus.Invoke((MethodInvoker)delegate
                {
                    lbStatus.Text = e.Error.Message;
                   
                });
            }
        }

        private void Dbbackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lbPercent.Invoke((MethodInvoker)delegate {
                lbPercent.Text = $"{e.Percent}%";
            });
        }

 
     

      
    }
}
