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
    public partial class QuanLiGiaoVien : Form
    {
        private string gioitinh;
        quan_li_sinh_vien_NCKHEntities data = new quan_li_sinh_vien_NCKHEntities();
        public QuanLiGiaoVien()
        {
            InitializeComponent();
            dtgr_DanhsachGV.DataSource=DataConnection.Danhsach("exec dbo.DanhSachGV").Tables[0];
            loadbomon();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dtgr_DanhsachGV.DataSource = DataConnection.Danhsach("exec dbo.TimkiemGV N'%"+txt_timkiem.Text+"%'").Tables[0];
        }
        private void loadbomon()
        {
            var tenbm = data.BoMons.ToList();
            foreach(BoMon item in tenbm)
            {
                cbb_bomon.Items.Add(item.tenbomon);
            }
        }
        private void thongtin()
        {
            var model = data.GiaoViens.Where(x => x.TenGV == txt_hoten.Text).ToList();
            foreach(GiaoVien item in model)
            {
                txt_magv.Text = item.MaGV;
                dtp_ngaysinhgv.Value =Convert.ToDateTime(item.ngaysinhgv);
                cbb_gioitinh.Text = item.gioitinhGV;
                var bommon = data.BoMons.Where(x => x.Mabomon == item.Mabomon).ToList();
                foreach(BoMon bm in bommon) { cbb_bomon.Text = bm.tenbomon; }
                cbb_luong.Text =Convert.ToString(item.luong);
            }
        }
        private void add()
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGV = txt_magv.Text;
            gv.TenGV = txt_hoten.Text;
            gv.ngaysinhgv = dtp_ngaysinhgv.Value;
            gv.gioitinhGV=cbb_gioitinh.Text;
            gv.luong =Convert.ToInt32(cbb_luong.Text);
            var mabm = data.BoMons.Where(x => x.tenbomon == cbb_bomon.Text).ToList();
            foreach(BoMon item in mabm) { gv.Mabomon = item.Mabomon; }
            data.GiaoViens.Add(gv);
            data.SaveChanges();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_magv.Text))
            {
                if(DataConnection.kiemtra("select dbo.kiemtraMGV('"+txt_magv.Text+"')")==false)
                {
                    add();
                    MessageBox.Show("Thêm thành công giáo viên " + txt_hoten.Text, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dtgr_DanhsachGV.DataSource=DataConnection.Danhsach("exec dbo.DanhSachGV").Tables[0];
                }else
                {
                    MessageBox.Show("Ma "+txt_magv.Text+" đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                MessageBox.Show("Bạn phải điền đấy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_hoten.Text))
            {
                DataConnection.ThucThi("exec dbo.Suagiaovien N'" + txt_hoten.Text + "','" + dtp_ngaysinhgv.Value + "',N'" + cbb_bomon.Text + "'," + cbb_luong.Text + "");
                MessageBox.Show("sửa thành công giáo viên " + txt_hoten.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgr_DanhsachGV.DataSource = DataConnection.Danhsach("exec dbo.DanhSachGV").Tables[0];
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên giáo viên cần sửa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
            thongtin();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txt_hoten.Text))
            {
                DialogResult result= MessageBox.Show("Bạn muốn xóa giáo viên " + txt_hoten.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                switch(result)
                {
                    case DialogResult.OK:
                        {
                            DataConnection.ThucThi("exec dbo.xoagiaovien N'" + txt_magv.Text + "'");
                            MessageBox.Show("xóa thành công giáo viên " + txt_hoten.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgr_DanhsachGV.DataSource = DataConnection.Danhsach("exec dbo.DanhSachGV").Tables[0];
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên giáo viên cần xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
