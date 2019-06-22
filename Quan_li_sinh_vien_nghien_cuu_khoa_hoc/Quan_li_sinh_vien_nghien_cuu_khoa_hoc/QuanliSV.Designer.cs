namespace Quan_li_sinh_vien_nghien_cuu_khoa_hoc
{
    partial class QuanLiSV
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
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.dtgr_danhsachSV = new System.Windows.Forms.DataGridView();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.cbb_detai = new System.Windows.Forms.ComboBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.cbb_lopsh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_capnhat = new System.Windows.Forms.Panel();
            this.cbb_ketqua = new System.Windows.Forms.ComboBox();
            this.cbb_vaitro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_noidungth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_danhsachSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_capnhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(12, 261);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 0;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // dtgr_danhsachSV
            // 
            this.dtgr_danhsachSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgr_danhsachSV.BackgroundColor = System.Drawing.Color.White;
            this.dtgr_danhsachSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr_danhsachSV.GridColor = System.Drawing.Color.DarkGray;
            this.dtgr_danhsachSV.Location = new System.Drawing.Point(16, 331);
            this.dtgr_danhsachSV.Name = "dtgr_danhsachSV";
            this.dtgr_danhsachSV.ReadOnly = true;
            this.dtgr_danhsachSV.Size = new System.Drawing.Size(761, 250);
            this.dtgr_danhsachSV.TabIndex = 1;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(84, 41);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(127, 20);
            this.txt_ma.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(288, 44);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(125, 20);
            this.txt_hoten.TabIndex = 5;
            this.txt_hoten.TextChanged += new System.EventHandler(this.txt_hoten_TextChanged);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(288, 89);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(125, 20);
            this.txt_diachi.TabIndex = 7;
            // 
            // cbb_detai
            // 
            this.cbb_detai.FormattingEnabled = true;
            this.cbb_detai.Location = new System.Drawing.Point(84, 136);
            this.cbb_detai.Name = "cbb_detai";
            this.cbb_detai.Size = new System.Drawing.Size(127, 21);
            this.cbb_detai.TabIndex = 8;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(97, 261);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(226, 20);
            this.txt_timkiem.TabIndex = 9;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gioitinh.Location = new System.Drawing.Point(84, 87);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(127, 21);
            this.cbb_gioitinh.TabIndex = 10;
            // 
            // cbb_lopsh
            // 
            this.cbb_lopsh.FormattingEnabled = true;
            this.cbb_lopsh.Location = new System.Drawing.Point(555, 84);
            this.cbb_lopsh.Name = "cbb_lopsh";
            this.cbb_lopsh.Size = new System.Drawing.Size(127, 21);
            this.cbb_lopsh.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_capnhat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_ngaysinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.cbb_lopsh);
            this.groupBox1.Controls.Add(this.cbb_detai);
            this.groupBox1.Controls.Add(this.cbb_gioitinh);
            this.groupBox1.Location = new System.Drawing.Point(13, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 211);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // panel_capnhat
            // 
            this.panel_capnhat.Controls.Add(this.cbb_ketqua);
            this.panel_capnhat.Controls.Add(this.cbb_vaitro);
            this.panel_capnhat.Controls.Add(this.label11);
            this.panel_capnhat.Controls.Add(this.label10);
            this.panel_capnhat.Controls.Add(this.txt_noidungth);
            this.panel_capnhat.Controls.Add(this.label9);
            this.panel_capnhat.Location = new System.Drawing.Point(6, 163);
            this.panel_capnhat.Name = "panel_capnhat";
            this.panel_capnhat.Size = new System.Drawing.Size(758, 44);
            this.panel_capnhat.TabIndex = 20;
            this.panel_capnhat.Visible = false;
            // 
            // cbb_ketqua
            // 
            this.cbb_ketqua.FormattingEnabled = true;
            this.cbb_ketqua.Items.AddRange(new object[] {
            "Hoàn thành",
            "Chưa hoàn thành"});
            this.cbb_ketqua.Location = new System.Drawing.Point(282, 11);
            this.cbb_ketqua.Name = "cbb_ketqua";
            this.cbb_ketqua.Size = new System.Drawing.Size(127, 21);
            this.cbb_ketqua.TabIndex = 26;
            // 
            // cbb_vaitro
            // 
            this.cbb_vaitro.FormattingEnabled = true;
            this.cbb_vaitro.Items.AddRange(new object[] {
            "Trưởng nhóm",
            "Thành viên"});
            this.cbb_vaitro.Location = new System.Drawing.Point(78, 12);
            this.cbb_vaitro.Name = "cbb_vaitro";
            this.cbb_vaitro.Size = new System.Drawing.Size(127, 21);
            this.cbb_vaitro.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Kết quả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Vai trò";
            // 
            // txt_noidungth
            // 
            this.txt_noidungth.Location = new System.Drawing.Point(549, 12);
            this.txt_noidungth.Name = "txt_noidungth";
            this.txt_noidungth.Size = new System.Drawing.Size(127, 20);
            this.txt_noidungth.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nội dung thực hiện";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Đề tài";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lớp sinh hoạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày sinh";
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(555, 47);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(127, 20);
            this.dt_ngaysinh.TabIndex = 14;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(536, 257);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(73, 64);
            this.btn_xoa.TabIndex = 21;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(438, 257);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(72, 64);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(338, 257);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(77, 64);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Danh sách sinh viên";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(622, 257);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(73, 64);
            this.btn_capnhat.TabIndex = 22;
            this.btn_capnhat.Text = "Nội dung thực hiện";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(269, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 31);
            this.label12.TabIndex = 23;
            this.label12.Text = "Quản Lý Sinh Viên";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(710, 257);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(73, 64);
            this.btn_thoat.TabIndex = 24;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // QuanLiSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 593);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dtgr_danhsachSV);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_timkiem);
            this.Name = "QuanLiSV";
            this.Text = "Quản lí sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_danhsachSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_capnhat.ResumeLayout(false);
            this.panel_capnhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridView dtgr_danhsachSV;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.ComboBox cbb_detai;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.ComboBox cbb_lopsh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel_capnhat;
        private System.Windows.Forms.TextBox txt_noidungth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_ketqua;
        private System.Windows.Forms.ComboBox cbb_vaitro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_thoat;
    }
}

