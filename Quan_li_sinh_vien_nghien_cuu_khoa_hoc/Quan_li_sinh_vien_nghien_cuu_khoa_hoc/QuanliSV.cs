using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_sinh_vien_nghien_cuu_khoa_hoc
{
    public partial class QuanLiSV : Form
    {
        quan_li_sinh_vien_NCKHEntities data = new quan_li_sinh_vien_NCKHEntities();
        private string query_dssv = "exec dbo.DanhsachSV";
        public QuanLiSV()
        {
            InitializeComponent();
            dtgr_danhsachSV.DataSource = DataConnection.Danhsach(query_dssv).Tables[0];
            danhsachlop();
            danhsachdetai();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_timkiem.Text))
            {
                dtgr_danhsachSV.DataSource = DataConnection.Danhsach("exec dbo.TimkiemSV N'%"+txt_timkiem.Text+"%'").Tables[0];
            }else
            {
                dtgr_danhsachSV.DataSource = DataConnection.Danhsach(query_dssv).Tables[0];
            }
        }
        private void danhsachlop()
        {
            var model = data.LopSHes.ToList();
            foreach(LopSH item in model)
            {
                cbb_lopsh.Items.Add(item.Tenlopsh);
            }
        }
        private void danhsachdetai()
        {
            var model = data.DetaiNCKHs.ToList();
            foreach (DetaiNCKH item in model)
            {
                cbb_detai.Items.Add(item.tendetai);
            }
        }
        private void add()
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = txt_ma.Text;
            sv.TenSV = txt_hoten.Text;
            sv.NgaySinh = dt_ngaysinh.Value;
            sv.gioitinh=cbb_gioitinh.Text;
            sv.Diachi = txt_diachi.Text;
            var malop= from p in data.LopSHes.Where(x => x.Tenlopsh == cbb_lopsh.Text) select p.MalopSH;
            foreach(string item in malop) { sv.MalopSH = item; }
            QuanliTH ql = new QuanliTH();
            ql.MaSV = txt_ma.Text;
            var madetai = from p in data.DetaiNCKHs where p.tendetai == cbb_detai.Text select p.Madetai;
            foreach(string item in madetai) { ql.Madetai = item; }
            data.SinhViens.Add(sv);
            data.QuanliTHs.Add(ql);
            data.SaveChanges();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_ma.Text))
            {
                if(DataConnection.kiemtra("select dbo.kiemtraMSV(N'"+txt_ma.Text+"')") ==false)
                {
                    add();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgr_danhsachSV.DataSource = DataConnection.Danhsach(query_dssv).Tables[0];
                }
                else
                {
                    MessageBox.Show("Mã "+txt_ma.Text+" đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void thongtin()
        {
            var model = data.SinhViens.Where(x => x.TenSV == txt_hoten.Text).ToList();
            foreach(SinhVien item in model)
            {
                txt_ma.Text = item.MaSV;
                txt_diachi.Text = item.Diachi;
                cbb_gioitinh.Text= item.gioitinh;
                if (item.NgaySinh == null) {}
                else{ dt_ngaysinh.Value = Convert.ToDateTime(item.NgaySinh); }
                var tenlop = data.LopSHes.Where(x => x.MalopSH == item.MalopSH).ToList();
                foreach(LopSH lop in tenlop) { cbb_lopsh.Text = lop.Tenlopsh; }
                var tendetai = from p in data.DetaiNCKHs join c in data.QuanliTHs on p.Madetai equals c.Madetai where c.MaSV == item.MaSV select p;
                foreach(DetaiNCKH dt in tendetai) { cbb_detai.Text = dt.tendetai; }
                var thuchien = data.QuanliTHs.Where(x => x.MaSV == item.MaSV).ToList();
                foreach(QuanliTH ql in thuchien)
                {
                    cbb_vaitro.Text = ql.vaitro;
                    cbb_ketqua.Text = ql.ketqua;
                    txt_noidungth.Text = ql.NDthuchien;
                }
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_hoten.Text))
            {
                DataConnection.ThucThi("exec dbo.suasv N'"+txt_hoten.Text+"','"+dt_ngaysinh.Text+"',N'"+cbb_lopsh.Text+"',N'"+txt_diachi.Text+"',N'"+cbb_detai.Text+"',N'"+txt_noidungth.Text+"',N'"+cbb_vaitro.Text+"',N'"+cbb_ketqua.Text+"'");
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgr_danhsachSV.DataSource = DataConnection.Danhsach(query_dssv).Tables[0];
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
            thongtin();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_hoten.Text))
            {
                DialogResult result= MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            DataConnection.ThucThi("exec dbo.XoaSV1 N'"+txt_hoten.Text+"'");
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgr_danhsachSV.DataSource = DataConnection.Danhsach(query_dssv).Tables[0];
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
                MessageBox.Show("Bạn chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            panel_capnhat.Visible = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            this.Visible = false;
            f.ShowDialog();
        }
    }
}
