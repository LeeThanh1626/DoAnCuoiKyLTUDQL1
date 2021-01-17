
namespace DoAnCuoiKy
{
    partial class DangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datengaysinh = new System.Windows.Forms.TextBox();
            this.cbbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtxacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDangKy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datengaysinh);
            this.groupBox1.Controls.Add(this.cbbPhanQuyen);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtxacnhanmatkhau);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttendangnhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaSo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(367, 483);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Thông tin đăng ký";
            this.groupBox1.UseWaitCursor = true;
            // 
            // datengaysinh
            // 
            this.datengaysinh.Location = new System.Drawing.Point(120, 129);
            this.datengaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(199, 27);
            this.datengaysinh.TabIndex = 24;
            this.datengaysinh.UseWaitCursor = true;
            this.datengaysinh.Validating += new System.ComponentModel.CancelEventHandler(this.datengaysinh_Validating);
            // 
            // cbbPhanQuyen
            // 
            this.cbbPhanQuyen.FormattingEnabled = true;
            this.cbbPhanQuyen.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbbPhanQuyen.Location = new System.Drawing.Point(146, 369);
            this.cbbPhanQuyen.Name = "cbbPhanQuyen";
            this.cbbPhanQuyen.Size = new System.Drawing.Size(56, 28);
            this.cbbPhanQuyen.TabIndex = 23;
            this.cbbPhanQuyen.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(23, 419);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(314, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Admin: 0--Học Sinh: 1--Giáo Viên: 2";
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(6, 372);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Loại Người Dùng:";
            this.label11.UseWaitCursor = true;
            // 
            // txtxacnhanmatkhau
            // 
            this.txtxacnhanmatkhau.Location = new System.Drawing.Point(146, 330);
            this.txtxacnhanmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtxacnhanmatkhau.Name = "txtxacnhanmatkhau";
            this.txtxacnhanmatkhau.Size = new System.Drawing.Size(173, 27);
            this.txtxacnhanmatkhau.TabIndex = 19;
            this.txtxacnhanmatkhau.UseSystemPasswordChar = true;
            this.txtxacnhanmatkhau.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(6, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Xác nhận mật khẩu:";
            this.label9.UseWaitCursor = true;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(120, 291);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(199, 27);
            this.txtmatkhau.TabIndex = 17;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.UseWaitCursor = true;
            this.txtmatkhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtmatkhau_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(6, 294);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mật khẩu:";
            this.label8.UseWaitCursor = true;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(120, 253);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(199, 27);
            this.txttendangnhap.TabIndex = 15;
            this.txttendangnhap.UseWaitCursor = true;
            this.txttendangnhap.Validating += new System.ComponentModel.CancelEventHandler(this.txttendangnhap_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(7, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tên đăng nhập:";
            this.label7.UseWaitCursor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 213);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 27);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(7, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone:";
            this.label6.UseWaitCursor = true;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam\t",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(120, 87);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(89, 28);
            this.cbbGioiTinh.TabIndex = 10;
            this.cbbGioiTinh.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 170);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 27);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.UseWaitCursor = true;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính:";
            this.label3.UseWaitCursor = true;
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(120, 51);
            this.txtMaSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(199, 27);
            this.txtMaSo.TabIndex = 3;
            this.txtMaSo.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã số:";
            this.label2.UseWaitCursor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 16);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(199, 27);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.UseWaitCursor = true;
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            this.label1.UseWaitCursor = true;
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.BtnDangKy.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDangKy.ForeColor = System.Drawing.Color.White;
            this.BtnDangKy.Location = new System.Drawing.Point(58, 561);
            this.BtnDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.Size = new System.Drawing.Size(107, 42);
            this.BtnDangKy.TabIndex = 1;
            this.BtnDangKy.Text = "Đăng ký";
            this.BtnDangKy.UseVisualStyleBackColor = false;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnCuoiKy.Properties.Resources.user_login_icon_24;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Exit.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(199, 561);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 42);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(133, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 45);
            this.label10.TabIndex = 4;
            this.label10.Text = "Registration";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(401, 614);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BtnDangKy);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtxacnhanmatkhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDangKy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbPhanQuyen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox datengaysinh;
    }
}

