namespace Quan_li_sinh_vien_nghien_cuu_khoa_hoc
{
    partial class DangNhap
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
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_matkhaumoi = new System.Windows.Forms.TextBox();
            this.bnt_dangnhap = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel_matkhaumoi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_thaydoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel_matkhaumoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(126, 44);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(166, 20);
            this.txt_taikhoan.TabIndex = 0;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(126, 86);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(166, 20);
            this.txt_matkhau.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_matkhau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel_matkhaumoi);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.bnt_dangnhap);
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Location = new System.Drawing.Point(57, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.Location = new System.Drawing.Point(117, 13);
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.PasswordChar = '*';
            this.txt_matkhaumoi.Size = new System.Drawing.Size(166, 20);
            this.txt_matkhaumoi.TabIndex = 2;
            // 
            // bnt_dangnhap
            // 
            this.bnt_dangnhap.Location = new System.Drawing.Point(353, 41);
            this.bnt_dangnhap.Name = "bnt_dangnhap";
            this.bnt_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.bnt_dangnhap.TabIndex = 3;
            this.bnt_dangnhap.Text = "Đăng nhập";
            this.bnt_dangnhap.UseVisualStyleBackColor = true;
            this.bnt_dangnhap.Click += new System.EventHandler(this.bnt_dangnhap_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Location = new System.Drawing.Point(469, 12);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(75, 36);
            this.btn_doimatkhau.TabIndex = 4;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(353, 84);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // panel_matkhaumoi
            // 
            this.panel_matkhaumoi.Controls.Add(this.btn_thaydoi);
            this.panel_matkhaumoi.Controls.Add(this.label3);
            this.panel_matkhaumoi.Controls.Add(this.txt_matkhaumoi);
            this.panel_matkhaumoi.Location = new System.Drawing.Point(9, 111);
            this.panel_matkhaumoi.Name = "panel_matkhaumoi";
            this.panel_matkhaumoi.Size = new System.Drawing.Size(432, 61);
            this.panel_matkhaumoi.TabIndex = 6;
            this.panel_matkhaumoi.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tài khoản";
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Location = new System.Drawing.Point(47, 89);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(52, 13);
            this.label_matkhau.TabIndex = 8;
            this.label_matkhau.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu mới";
            // 
            // btn_thaydoi
            // 
            this.btn_thaydoi.Location = new System.Drawing.Point(344, 13);
            this.btn_thaydoi.Name = "btn_thaydoi";
            this.btn_thaydoi.Size = new System.Drawing.Size(75, 29);
            this.btn_thaydoi.TabIndex = 10;
            this.btn_thaydoi.Text = "Thay đổi";
            this.btn_thaydoi.UseVisualStyleBackColor = true;
            this.btn_thaydoi.Click += new System.EventHandler(this.btn_thaydoi_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_doimatkhau);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_matkhaumoi.ResumeLayout(false);
            this.panel_matkhaumoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_matkhaumoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_matkhaumoi;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.Button bnt_dangnhap;
        private System.Windows.Forms.Button btn_thaydoi;
    }
}