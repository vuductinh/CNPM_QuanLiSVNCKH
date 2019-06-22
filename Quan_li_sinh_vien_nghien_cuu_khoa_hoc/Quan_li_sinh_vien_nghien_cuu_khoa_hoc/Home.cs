using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_sinh_vien_nghien_cuu_khoa_hoc
{
    public partial class Home : Form
    {
        private string query_dssv = "exec dbo.DanhsachSV";
        public Home()
        {
            InitializeComponent();
            dtgr_danhsachsv.DataSource = DataConnection.Danhsach(query_dssv).Tables[0];
        }
        public Home(string thongtin)
        {
            InitializeComponent();
            dtgr_danhsachsv.DataSource = DataConnection.Danhsach(query_dssv).Tables[0];
            lab_thongtin.Text = thongtin;
        }
        private void btn_quanlisinhvien_Click(object sender, EventArgs e)
        {
            QuanLiSV f = new QuanLiSV();
            this.Visible = false;
            f.ShowDialog();
        }

        private void btn_quanligiaovien_Click(object sender, EventArgs e)
        {
            QuanLiGiaoVien f = new QuanLiGiaoVien();
            this.Visible = false;
            f.ShowDialog();
        }

        private void btn_quanlidetai_Click(object sender, EventArgs e)
        {
            Quanlidetai f = new Quanlidetai();
            this.Visible = false;
            f.ShowDialog();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
