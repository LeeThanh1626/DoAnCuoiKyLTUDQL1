
namespace DoAnCuoiKy
{
    partial class ViewReportImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.cbbSheet = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBrowes = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lTUDQL1DataSet = new DoAnCuoiKy.LTUDQL1DataSet();
            this.uSERTableAdapter = new DoAnCuoiKy.LTUDQL1DataSetTableAdapters.USERTableAdapter();
            this.fHoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMaSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNgaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMatKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIDPhanQuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTUDQL1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(497, 397);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 31);
            this.btnExport.TabIndex = 106;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(390, 397);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(84, 32);
            this.btnImport.TabIndex = 105;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(243, 400);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(121, 24);
            this.cbbSheet.TabIndex = 104;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(96, 407);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 103;
            this.label12.Text = "Sheet";
            // 
            // btnBrowes
            // 
            this.btnBrowes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnBrowes.ForeColor = System.Drawing.Color.White;
            this.btnBrowes.Location = new System.Drawing.Point(569, 360);
            this.btnBrowes.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(79, 27);
            this.btnBrowes.TabIndex = 102;
            this.btnBrowes.Text = "...";
            this.btnBrowes.UseVisualStyleBackColor = false;
            this.btnBrowes.Click += new System.EventHandler(this.btnBrowes_Click);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(243, 360);
            this.txtfilename.Margin = new System.Windows.Forms.Padding(4);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(318, 22);
            this.txtfilename.TabIndex = 101;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(96, 366);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 100;
            this.label13.Text = "File Name";
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.AutoGenerateColumns = false;
            this.dataGridViewImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fHoTenDataGridViewTextBoxColumn,
            this.fMaSoDataGridViewTextBoxColumn,
            this.fEmailDataGridViewTextBoxColumn,
            this.fGioiTinhDataGridViewTextBoxColumn,
            this.fNgaySinhDataGridViewTextBoxColumn,
            this.fPhoneDataGridViewTextBoxColumn,
            this.fTenDangNhapDataGridViewTextBoxColumn,
            this.fMatKhauDataGridViewTextBoxColumn,
            this.fIDPhanQuyenDataGridViewTextBoxColumn});
            this.dataGridViewImport.DataSource = this.importUserBindingSource;
            this.dataGridViewImport.Location = new System.Drawing.Point(2, 40);
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.RowHeadersWidth = 51;
            this.dataGridViewImport.RowTemplate.Height = 24;
            this.dataGridViewImport.Size = new System.Drawing.Size(782, 313);
            this.dataGridViewImport.TabIndex = 107;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.lTUDQL1DataSet;
            // 
            // lTUDQL1DataSet
            // 
            this.lTUDQL1DataSet.DataSetName = "LTUDQL1DataSet";
            this.lTUDQL1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // fHoTenDataGridViewTextBoxColumn
            // 
            this.fHoTenDataGridViewTextBoxColumn.DataPropertyName = "f_HoTen";
            this.fHoTenDataGridViewTextBoxColumn.HeaderText = "f_HoTen";
            this.fHoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fHoTenDataGridViewTextBoxColumn.Name = "fHoTenDataGridViewTextBoxColumn";
            this.fHoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fMaSoDataGridViewTextBoxColumn
            // 
            this.fMaSoDataGridViewTextBoxColumn.DataPropertyName = "f_MaSo";
            this.fMaSoDataGridViewTextBoxColumn.HeaderText = "f_MaSo";
            this.fMaSoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fMaSoDataGridViewTextBoxColumn.Name = "fMaSoDataGridViewTextBoxColumn";
            this.fMaSoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fEmailDataGridViewTextBoxColumn
            // 
            this.fEmailDataGridViewTextBoxColumn.DataPropertyName = "f_Email";
            this.fEmailDataGridViewTextBoxColumn.HeaderText = "f_Email";
            this.fEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fEmailDataGridViewTextBoxColumn.Name = "fEmailDataGridViewTextBoxColumn";
            this.fEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fGioiTinhDataGridViewTextBoxColumn
            // 
            this.fGioiTinhDataGridViewTextBoxColumn.DataPropertyName = "f_GioiTinh";
            this.fGioiTinhDataGridViewTextBoxColumn.HeaderText = "f_GioiTinh";
            this.fGioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fGioiTinhDataGridViewTextBoxColumn.Name = "fGioiTinhDataGridViewTextBoxColumn";
            this.fGioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNgaySinhDataGridViewTextBoxColumn
            // 
            this.fNgaySinhDataGridViewTextBoxColumn.DataPropertyName = "f_NgaySinh";
            this.fNgaySinhDataGridViewTextBoxColumn.HeaderText = "f_NgaySinh";
            this.fNgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNgaySinhDataGridViewTextBoxColumn.Name = "fNgaySinhDataGridViewTextBoxColumn";
            this.fNgaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fPhoneDataGridViewTextBoxColumn
            // 
            this.fPhoneDataGridViewTextBoxColumn.DataPropertyName = "f_Phone";
            this.fPhoneDataGridViewTextBoxColumn.HeaderText = "f_Phone";
            this.fPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fPhoneDataGridViewTextBoxColumn.Name = "fPhoneDataGridViewTextBoxColumn";
            this.fPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fTenDangNhapDataGridViewTextBoxColumn
            // 
            this.fTenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "f_TenDangNhap";
            this.fTenDangNhapDataGridViewTextBoxColumn.HeaderText = "f_TenDangNhap";
            this.fTenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fTenDangNhapDataGridViewTextBoxColumn.Name = "fTenDangNhapDataGridViewTextBoxColumn";
            this.fTenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fMatKhauDataGridViewTextBoxColumn
            // 
            this.fMatKhauDataGridViewTextBoxColumn.DataPropertyName = "f_MatKhau";
            this.fMatKhauDataGridViewTextBoxColumn.HeaderText = "f_MatKhau";
            this.fMatKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fMatKhauDataGridViewTextBoxColumn.Name = "fMatKhauDataGridViewTextBoxColumn";
            this.fMatKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIDPhanQuyenDataGridViewTextBoxColumn
            // 
            this.fIDPhanQuyenDataGridViewTextBoxColumn.DataPropertyName = "f_IDPhanQuyen";
            this.fIDPhanQuyenDataGridViewTextBoxColumn.HeaderText = "f_IDPhanQuyen";
            this.fIDPhanQuyenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIDPhanQuyenDataGridViewTextBoxColumn.Name = "fIDPhanQuyenDataGridViewTextBoxColumn";
            this.fIDPhanQuyenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importUserBindingSource
            // 
            this.importUserBindingSource.DataSource = typeof(DoAnCuoiKy.Model.ImportUser);
            // 
            // ViewReportImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.dataGridViewImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cbbSheet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBrowes);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.label13);
            this.Name = "ViewReportImport";
            this.Text = "ViewReportImport";
            this.Load += new System.EventHandler(this.ViewReportImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTUDQL1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBrowes;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMaSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMatKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIDPhanQuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource importUserBindingSource;
        private LTUDQL1DataSet lTUDQL1DataSet;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private LTUDQL1DataSetTableAdapters.USERTableAdapter uSERTableAdapter;
    }
}