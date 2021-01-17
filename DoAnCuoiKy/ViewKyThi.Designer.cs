namespace DoAnCuoiKy
{
    partial class ViewKyThi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KetQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_KyThi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SuaKT = new System.Windows.Forms.Button();
            this.btn_XoaKT = new System.Windows.Forms.Button();
            this.btn_TaoKyThi = new System.Windows.Forms.Button();
            this.txtmahv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmadt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmakt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChonKy = new System.Windows.Forms.TextBox();
            this.btn_LoadReport = new System.Windows.Forms.Button();
            this.ThiSinhRPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KyThi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThiSinhRPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KetQuaBindingSource
            // 
            this.KetQuaBindingSource.DataSource = typeof(DoAnCuoiKy.Model.KetQua);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(944, 499);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 54);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa Kỳ Thi";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(727, 499);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 54);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa Kỳ Thi";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(524, 499);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 54);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Tạo Kỳ Thi";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1328, 869);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(1328, 466);
            this.splitContainer2.SplitterDistance = 647;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_KyThi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Kỳ Thi";
            // 
            // dgv_KyThi
            // 
            this.dgv_KyThi.AllowUserToAddRows = false;
            this.dgv_KyThi.AllowUserToDeleteRows = false;
            this.dgv_KyThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KyThi.ColumnHeadersHeight = 29;
            this.dgv_KyThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KyThi.Location = new System.Drawing.Point(3, 23);
            this.dgv_KyThi.Name = "dgv_KyThi";
            this.dgv_KyThi.ReadOnly = true;
            this.dgv_KyThi.RowHeadersWidth = 51;
            this.dgv_KyThi.RowTemplate.Height = 24;
            this.dgv_KyThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KyThi.Size = new System.Drawing.Size(641, 440);
            this.dgv_KyThi.TabIndex = 60;
            this.dgv_KyThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KyThi_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txttg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_SuaKT);
            this.groupBox2.Controls.Add(this.btn_XoaKT);
            this.groupBox2.Controls.Add(this.btn_TaoKyThi);
            this.groupBox2.Controls.Add(this.txtmahv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtmadt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtmant);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmakt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 466);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // txttg
            // 
            this.txttg.Location = new System.Drawing.Point(170, 228);
            this.txttg.Name = "txttg";
            this.txttg.Size = new System.Drawing.Size(232, 27);
            this.txttg.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(66, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Thời Gian";
            // 
            // btn_SuaKT
            // 
            this.btn_SuaKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_SuaKT.ForeColor = System.Drawing.Color.White;
            this.btn_SuaKT.Location = new System.Drawing.Point(344, 370);
            this.btn_SuaKT.Name = "btn_SuaKT";
            this.btn_SuaKT.Size = new System.Drawing.Size(110, 54);
            this.btn_SuaKT.TabIndex = 69;
            this.btn_SuaKT.Text = "Sửa Kỳ Thi";
            this.btn_SuaKT.UseVisualStyleBackColor = false;
            this.btn_SuaKT.Click += new System.EventHandler(this.btn_SuaKT_Click);
            // 
            // btn_XoaKT
            // 
            this.btn_XoaKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_XoaKT.ForeColor = System.Drawing.Color.White;
            this.btn_XoaKT.Location = new System.Drawing.Point(204, 370);
            this.btn_XoaKT.Name = "btn_XoaKT";
            this.btn_XoaKT.Size = new System.Drawing.Size(110, 54);
            this.btn_XoaKT.TabIndex = 68;
            this.btn_XoaKT.Text = "Xóa Kỳ Thi";
            this.btn_XoaKT.UseVisualStyleBackColor = false;
            this.btn_XoaKT.Click += new System.EventHandler(this.btn_XoaKT_Click);
            // 
            // btn_TaoKyThi
            // 
            this.btn_TaoKyThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_TaoKyThi.ForeColor = System.Drawing.Color.White;
            this.btn_TaoKyThi.Location = new System.Drawing.Point(65, 370);
            this.btn_TaoKyThi.Name = "btn_TaoKyThi";
            this.btn_TaoKyThi.Size = new System.Drawing.Size(110, 54);
            this.btn_TaoKyThi.TabIndex = 67;
            this.btn_TaoKyThi.Text = "Tạo Kỳ Thi";
            this.btn_TaoKyThi.UseVisualStyleBackColor = false;
            this.btn_TaoKyThi.Click += new System.EventHandler(this.btn_TaoKyThi_Click);
            // 
            // txtmahv
            // 
            this.txtmahv.Location = new System.Drawing.Point(170, 288);
            this.txtmahv.Name = "txtmahv";
            this.txtmahv.Size = new System.Drawing.Size(232, 27);
            this.txtmahv.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(44, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Mã Học Viên";
            // 
            // txtmadt
            // 
            this.txtmadt.Location = new System.Drawing.Point(170, 165);
            this.txtmadt.Name = "txtmadt";
            this.txtmadt.Size = new System.Drawing.Size(232, 27);
            this.txtmadt.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(66, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Mã Đề Thi";
            // 
            // txtmant
            // 
            this.txtmant.Location = new System.Drawing.Point(170, 99);
            this.txtmant.Name = "txtmant";
            this.txtmant.Size = new System.Drawing.Size(232, 27);
            this.txtmant.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ngày Thi";
            // 
            // txtmakt
            // 
            this.txtmakt.Location = new System.Drawing.Point(170, 37);
            this.txtmakt.Name = "txtmakt";
            this.txtmakt.Size = new System.Drawing.Size(232, 27);
            this.txtmakt.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mã Kỳ Thi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtChonKy);
            this.groupBox3.Controls.Add(this.btn_LoadReport);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1328, 399);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu Báo Cáo";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "RPTheoKy";
            reportDataSource1.Value = this.ThiSinhRPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCuoiKy.Report.PrintThiSinhTheoKyThi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1322, 295);
            this.reportViewer1.TabIndex = 8;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chọn Kỳ Thi";
            // 
            // txtChonKy
            // 
            this.txtChonKy.Location = new System.Drawing.Point(508, 354);
            this.txtChonKy.Name = "txtChonKy";
            this.txtChonKy.Size = new System.Drawing.Size(136, 27);
            this.txtChonKy.TabIndex = 6;
            this.txtChonKy.Text = "KT01";
            // 
            // btn_LoadReport
            // 
            this.btn_LoadReport.Location = new System.Drawing.Point(665, 348);
            this.btn_LoadReport.Name = "btn_LoadReport";
            this.btn_LoadReport.Size = new System.Drawing.Size(125, 34);
            this.btn_LoadReport.TabIndex = 5;
            this.btn_LoadReport.Text = "Xem thống kê";
            this.btn_LoadReport.UseVisualStyleBackColor = true;
            this.btn_LoadReport.Click += new System.EventHandler(this.btn_LoadReport_Click);
            // 
            // ThiSinhRPBindingSource
            // 
            this.ThiSinhRPBindingSource.DataSource = typeof(DoAnCuoiKy.Model.ThiSinhRP);
            // 
            // ViewKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 869);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewKyThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KyThi";
            this.Load += new System.EventHandler(this.ViewKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KyThi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThiSinhRPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.BindingSource KetQuaBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_KyThi;
        private System.Windows.Forms.Button btn_SuaKT;
        private System.Windows.Forms.Button btn_XoaKT;
        private System.Windows.Forms.Button btn_TaoKyThi;
        private System.Windows.Forms.TextBox txtmahv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmadt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmakt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChonKy;
        private System.Windows.Forms.Button btn_LoadReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThiSinhRPBindingSource;
    }
}