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
    public partial class ViewReportImport : Form
    {
        public ViewReportImport()
        {
            InitializeComponent();
            LoadData();
        }
        
        DataTableCollection tableCollection;
        private void LoadData()
        {
            using (var db = new LTUDQL1DataContext())
            {
                dataGridViewImport.DataSource = db.USERs.Select(u => u);
            }
        }
        private void btnBrowes_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbbSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=LTUDQL1;Integrated Security=True";
                DapperPlusManager.Entity<ImportUser>().Table("USER");
                List<ImportUser> uSERs = importUserBindingSource.DataSource as List<ImportUser>;
                if (uSERs != null)
                {
                    con(connectionString, uSERs);
                }
                MessageBox.Show("Import Thành Công!!!");
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void con(string connectionString, List<ImportUser> uSERs)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.BulkInsert(uSERs);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wordbook = new XLWorkbook())
                        {
                            wordbook.Worksheets.Add(this.lTUDQL1DataSet.USER.CopyToDataTable(), "uSERs");
                            wordbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Thành công export excel data!!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ViewReportImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lTUDQL1DataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.lTUDQL1DataSet.USER);

        }

        private void cbbSheet_SelectedIndexChanged1(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbSheet.SelectedItem.ToString()];
            //dgv_NguoiDung.DataSource = dt;
            if (dt != null)
            {
                List<ImportUser> uSERs = new List<ImportUser>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ImportUser uSER = new ImportUser();
                    uSER.f_HoTen = dt.Rows[i]["f_HoTen"].ToString();
                    uSER.f_Email = dt.Rows[i]["f_Email"].ToString();
                    uSER.f_NgaySinh = dt.Rows[i]["f_NgaySinh"].ToString();
                    uSER.f_GioiTinh = dt.Rows[i]["f_GioiTinh"].ToString();
                    uSER.f_Phone = dt.Rows[i]["f_Phone"].ToString();
                    uSER.f_MaSo = dt.Rows[i]["f_MaSo"].ToString();
                    uSER.f_TenDangNhap = dt.Rows[i]["f_TenDangNhap"].ToString();
                    uSER.f_MatKhau = dt.Rows[i]["f_MatKhau"].ToString();
                    uSER.f_IDPhanQuyen = dt.Rows[i]["f_IDPhanQuyen"].ToString();
                    uSERs.Add(uSER);
                }
                importUserBindingSource.DataSource = uSERs;
            }
        }
    }
}
