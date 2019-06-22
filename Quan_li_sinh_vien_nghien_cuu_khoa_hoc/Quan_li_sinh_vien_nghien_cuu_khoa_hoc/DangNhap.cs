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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void bnt_dangnhap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_taikhoan.Text))
            {
                if(DataConnection.kiemtradangnhap(txt_taikhoan.Text,txt_matkhau.Text)==true)
                {
                    Home f = new Home(txt_taikhoan.Text);
                    this.Visible = false;
                    f.ShowDialog();
                }else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            panel_matkhaumoi.Visible = true;
            label_matkhau.Text = "Mật khẩu cũ";
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_thaydoi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_matkhaumoi.Text))
            {
                DataConnection.ThucThi("update dbo.taikhoan set matkhau=N'" + txt_matkhaumoi.Text + "' where tentaikhoan=N'" + txt_taikhoan.Text + "'");
                MessageBox.Show("Đã đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel_matkhaumoi.Visible = false;
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
