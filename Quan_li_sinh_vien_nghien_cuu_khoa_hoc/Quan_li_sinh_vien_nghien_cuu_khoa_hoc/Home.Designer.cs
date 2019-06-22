namespace Quan_li_sinh_vien_nghien_cuu_khoa_hoc
{
    partial class Home
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
            this.dtgr_danhsachsv = new System.Windows.Forms.DataGridView();
            this.btn_quanlisinhvien = new System.Windows.Forms.Button();
            this.btn_quanligiaovien = new System.Windows.Forms.Button();
            this.btn_quanlidetai = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_thongtin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_danhsachsv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgr_danhsachsv
            // 
            this.dtgr_danhsachsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgr_danhsachsv.BackgroundColor = System.Drawing.Color.White;
            this.dtgr_danhsachsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgr_danhsachsv.Location = new System.Drawing.Point(5, 179);
            this.dtgr_danhsachsv.Name = "dtgr_danhsachsv";
            this.dtgr_danhsachsv.Size = new System.Drawing.Size(862, 410);
            this.dtgr_danhsachsv.TabIndex = 0;
            // 
            // btn_quanlisinhvien
            // 
            this.btn_quanlisinhvien.Location = new System.Drawing.Point(240, 96);
            this.btn_quanlisinhvien.Name = "btn_quanlisinhvien";
            this.btn_quanlisinhvien.Size = new System.Drawing.Size(75, 59);
            this.btn_quanlisinhvien.TabIndex = 1;
            this.btn_quanlisinhvien.Text = "Quản Lý Sinh Viên";
            this.btn_quanlisinhvien.UseVisualStyleBackColor = true;
            this.btn_quanlisinhvien.Click += new System.EventHandler(this.btn_quanlisinhvien_Click);
            // 
            // btn_quanligiaovien
            // 
            this.btn_quanligiaovien.Location = new System.Drawing.Point(383, 96);
            this.btn_quanligiaovien.Name = "btn_quanligiaovien";
            this.btn_quanligiaovien.Size = new System.Drawing.Size(75, 59);
            this.btn_quanligiaovien.TabIndex = 2;
            this.btn_quanligiaovien.Text = "Quản Lý Giáo Viên";
            this.btn_quanligiaovien.UseVisualStyleBackColor = true;
            this.btn_quanligiaovien.Click += new System.EventHandler(this.btn_quanligiaovien_Click);
            // 
            // btn_quanlidetai
            // 
            this.btn_quanlidetai.Location = new System.Drawing.Point(505, 96);
            this.btn_quanlidetai.Name = "btn_quanlidetai";
            this.btn_quanlidetai.Size = new System.Drawing.Size(75, 59);
            this.btn_quanlidetai.TabIndex = 3;
            this.btn_quanlidetai.Text = "Quản Lý Đề Tài";
            this.btn_quanlidetai.UseVisualStyleBackColor = true;
            this.btn_quanlidetai.Click += new System.EventHandler(this.btn_quanlidetai_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Location = new System.Drawing.Point(785, 12);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(75, 23);
            this.btn_dangxuat.TabIndex = 4;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // lab_thongtin
            // 
            this.lab_thongtin.AutoSize = true;
            this.lab_thongtin.Location = new System.Drawing.Point(794, 38);
            this.lab_thongtin.Name = "lab_thongtin";
            this.lab_thongtin.Size = new System.Drawing.Size(52, 13);
            this.lab_thongtin.TabIndex = 6;
            this.lab_thongtin.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản Lý Sinh Viên Nghiên Cứu Khoa Học";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_thongtin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.btn_quanlidetai);
            this.Controls.Add(this.btn_quanligiaovien);
            this.Controls.Add(this.btn_quanlisinhvien);
            this.Controls.Add(this.dtgr_danhsachsv);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dtgr_danhsachsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgr_danhsachsv;
        private System.Windows.Forms.Button btn_quanlisinhvien;
        private System.Windows.Forms.Button btn_quanligiaovien;
        private System.Windows.Forms.Button btn_quanlidetai;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_thongtin;
        private System.Windows.Forms.Label label2;
    }
}