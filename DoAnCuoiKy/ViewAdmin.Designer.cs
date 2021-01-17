
namespace DoAnCuoiKy
{
    partial class ViewAdmin
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
            this.btnQLNguoiDung = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            this.btnQuanLyHeThong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnQLNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNguoiDung.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnQLNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnQLNguoiDung.Location = new System.Drawing.Point(111, 124);
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.Size = new System.Drawing.Size(189, 89);
            this.btnQLNguoiDung.TabIndex = 0;
            this.btnQLNguoiDung.Text = "Quản Lý Người Dùng";
            this.btnQLNguoiDung.UseVisualStyleBackColor = false;
            this.btnQLNguoiDung.Click += new System.EventHandler(this.btnQLNguoiDung_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label10.Location = new System.Drawing.Point(312, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 45);
            this.label10.TabIndex = 5;
            this.label10.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnCuoiKy.Properties.Resources.user_login_icon_24;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Exit.Location = new System.Drawing.Point(747, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 20);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseWaitCursor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnQuanLyHeThong
            // 
            this.btnQuanLyHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnQuanLyHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyHeThong.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyHeThong.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyHeThong.Location = new System.Drawing.Point(471, 124);
            this.btnQuanLyHeThong.Name = "btnQuanLyHeThong";
            this.btnQuanLyHeThong.Size = new System.Drawing.Size(189, 89);
            this.btnQuanLyHeThong.TabIndex = 10;
            this.btnQuanLyHeThong.Text = "Quản Lý Hệ Thống";
            this.btnQuanLyHeThong.UseVisualStyleBackColor = false;
            this.btnQuanLyHeThong.Click += new System.EventHandler(this.btnQuanLyHeThong_Click);
            // 
            // ViewAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuanLyHeThong);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnQLNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAdmin";
            this.Text = "Quản Lý Người Dùng : ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLNguoiDung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Button btnQuanLyHeThong;
    }
}