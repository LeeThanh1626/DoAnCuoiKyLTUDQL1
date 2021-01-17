namespace DoAnCuoiKy
{
    partial class ViewHocSinh
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
            this.KetQuaRPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KetQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_HocVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRPCauHoi = new System.Windows.Forms.TextBox();
            this.btn_RPCauhoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChonKy = new System.Windows.Forms.TextBox();
            this.rpv_HocSinh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_LoadReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaRPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KetQuaRPBindingSource
            // 
            this.KetQuaRPBindingSource.DataSource = typeof(DoAnCuoiKy.Model.KetQuaRP);
            // 
            // KetQuaBindingSource
            // 
            this.KetQuaBindingSource.DataSource = typeof(DoAnCuoiKy.Model.KetQua);
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1016, 714);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_HocVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả Thí Sinh";
            // 
            // dgv_HocVien
            // 
            this.dgv_HocVien.AllowUserToAddRows = false;
            this.dgv_HocVien.AllowUserToDeleteRows = false;
            this.dgv_HocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HocVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_HocVien.ColumnHeadersHeight = 29;
            this.dgv_HocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HocVien.Location = new System.Drawing.Point(3, 23);
            this.dgv_HocVien.Name = "dgv_HocVien";
            this.dgv_HocVien.ReadOnly = true;
            this.dgv_HocVien.RowHeadersWidth = 51;
            this.dgv_HocVien.RowTemplate.Height = 24;
            this.dgv_HocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HocVien.Size = new System.Drawing.Size(1010, 332);
            this.dgv_HocVien.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRPCauHoi);
            this.groupBox2.Controls.Add(this.btn_RPCauhoi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtChonKy);
            this.groupBox2.Controls.Add(this.rpv_HocSinh);
            this.groupBox2.Controls.Add(this.btn_LoadReport);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 352);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê Kết Quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn Câu Hỏi";
            // 
            // txtRPCauHoi
            // 
            this.txtRPCauHoi.Location = new System.Drawing.Point(659, 318);
            this.txtRPCauHoi.Name = "txtRPCauHoi";
            this.txtRPCauHoi.Size = new System.Drawing.Size(136, 27);
            this.txtRPCauHoi.TabIndex = 6;
            this.txtRPCauHoi.Text = "CH02";
            // 
            // btn_RPCauhoi
            // 
            this.btn_RPCauhoi.Location = new System.Drawing.Point(819, 312);
            this.btn_RPCauhoi.Name = "btn_RPCauhoi";
            this.btn_RPCauhoi.Size = new System.Drawing.Size(151, 34);
            this.btn_RPCauhoi.TabIndex = 5;
            this.btn_RPCauhoi.Text = "Xem Thống Kê";
            this.btn_RPCauhoi.UseVisualStyleBackColor = true;
            this.btn_RPCauhoi.Click += new System.EventHandler(this.btn_RPCauhoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn Kỳ Thi";
            // 
            // txtChonKy
            // 
            this.txtChonKy.Location = new System.Drawing.Point(100, 318);
            this.txtChonKy.Name = "txtChonKy";
            this.txtChonKy.Size = new System.Drawing.Size(136, 27);
            this.txtChonKy.TabIndex = 3;
            this.txtChonKy.Text = "KT01";
            // 
            // rpv_HocSinh
            // 
            this.rpv_HocSinh.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "DataSetHV";
            reportDataSource1.Value = this.KetQuaRPBindingSource;
            this.rpv_HocSinh.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_HocSinh.LocalReport.ReportEmbeddedResource = "DoAnCuoiKy.Report.KetQuaRP.rdlc";
            this.rpv_HocSinh.Location = new System.Drawing.Point(3, 23);
            this.rpv_HocSinh.Name = "rpv_HocSinh";
            this.rpv_HocSinh.ServerReport.BearerToken = null;
            this.rpv_HocSinh.Size = new System.Drawing.Size(1010, 260);
            this.rpv_HocSinh.TabIndex = 2;
            this.rpv_HocSinh.Load += new System.EventHandler(this.rpv_HocSinh_Load);
            // 
            // btn_LoadReport
            // 
            this.btn_LoadReport.Location = new System.Drawing.Point(257, 312);
            this.btn_LoadReport.Name = "btn_LoadReport";
            this.btn_LoadReport.Size = new System.Drawing.Size(146, 34);
            this.btn_LoadReport.TabIndex = 1;
            this.btn_LoadReport.Text = "Xem thống kê";
            this.btn_LoadReport.UseVisualStyleBackColor = true;
            this.btn_LoadReport.Click += new System.EventHandler(this.btn_LoadReport_Click);
            // 
            // ViewHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 714);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewHocSinh";
            this.Text = "HocSinh";
            this.Load += new System.EventHandler(this.ViewHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaRPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KetQuaBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_HocVien;
        private System.Windows.Forms.BindingSource KetQuaBindingSource;
        private System.Windows.Forms.Button btn_LoadReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_HocSinh;
        private System.Windows.Forms.BindingSource KetQuaRPBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChonKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRPCauHoi;
        private System.Windows.Forms.Button btn_RPCauhoi;
    }
}