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
    public partial class Quanlidetai : Form
    {
        quan_li_sinh_vien_NCKHEntities data = new quan_li_sinh_vien_NCKHEntities();
        private string query_dsdetai = "exec dbo.danhsachdetai";
        public Quanlidetai()
        {
            InitializeComponent();
            dtgr_danhsachdetai.DataSource = DataConnection.Danhsach(query_dsdetai).Tables[0];
            loadchuyennganh();
            loadgiaovien();
        }
        private void loadgiaovien()
        {
            var model = data.GiaoViens.ToList();
            foreach (GiaoVien gv in model) { cbb_giaovien.Items.Add(gv.TenGV); }
        }
        private void loadchuyennganh()
        {
            var model = data.ChuyenNganhs.ToList();
            foreach (ChuyenNganh item in model) { cbb_chuyennganh.Items.Add(item.tenCN); }
        }
        private void add()
        {
            DetaiNCKH dt = new DetaiNCKH();
            dt.Madetai = txt_madt.Text;
            dt.tendetai = txt_tendt.Text;
            dt.ngaybd = dtp_ngaybd.Value;
            dt.ngaykt = dtp_ngaykt.Value;
            var magv = data.GiaoViens.Where(x => x.TenGV == cbb_giaovien.Text).ToList();
            foreach(GiaoVien item in magv) { dt.MaGV = item.MaGV; }
            var macn = data.ChuyenNganhs.Where(x => x.tenCN == cbb_chuyennganh.Text).ToList();
            foreach(ChuyenNganh item in macn) { dt.MaCN = item.MaCN; }
            dt.noidung = txt_noidung.Text;
            data.DetaiNCKHs.Add(dt);
            data.SaveChanges();
        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            dtgr_danhsachdetai.DataSource=DataConnection.Danhsach("exec dbo.timkiemdetai N'%"+txt_timkiem.Text+"%'").Tables[0];
        }
        private void thongtin()
        {
            var model = data.DetaiNCKHs.Where(x => x.tendetai == txt_tendt.Text).ToList();
            foreach(DetaiNCKH item in model)
            {
                txt_madt.Text = item.Madetai;
                txt_noidung.Text = item.noidung;
                dtp_ngaybd.Text =Convert.ToString(item.ngaybd);
                dtp_ngaykt.Text = Convert.ToString(item.ngaykt);
                var macn = data.ChuyenNganhs.Where(x => x.MaCN == item.MaCN).ToList();
                foreach (ChuyenNganh cn in macn) { cbb_chuyennganh.Text = cn.tenCN; }
                var magv = data.GiaoViens.Where(x => x.MaGV == item.MaGV).ToList();
                foreach(GiaoVien gv in magv) { cbb_giaovien.Text = gv.TenGV; }
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_madt.Text))
            {
                if(DataConnection.kiemtra("select dbo.kiemtramadt('"+txt_madt.Text+"')")==false)
                {
                    add();
                    MessageBox.Show("Thêm thành công đề tài "+txt_tendt.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgr_danhsachdetai.DataSource = DataConnection.Danhsach(query_dsdetai).Tables[0];
                }
                else
                {
                    MessageBox.Show("Mã " + txt_madt.Text + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_tendt_TextChanged(object sender, EventArgs e)
        {
            thongtin();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_tendt.Text))
            {
                DataConnection.ThucThi("exec dbo.suadetai N'"+txt_tendt.Text+"',N'"+txt_noidung.Text+"','"+dtp_ngaybd.Text+"','"+dtp_ngaykt.Text+"',N'"+cbb_giaovien.Text+"',N'"+cbb_chuyennganh.Text+"'");
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgr_danhsachdetai.DataSource = DataConnection.Danhsach(query_dsdetai).Tables[0];
            }else
            {
                MessageBox.Show("Bạn vui lòng nhập tên đề tài cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_tendt.Text))
            {
                DialogResult result= MessageBox.Show("Bạn có muốn xóa đề tài " + txt_tendt.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                switch(result)
                {
                    case DialogResult.OK:
                        {
                            DataConnection.ThucThi("exec dbo.xoadetai N'"+txt_tendt.Text+"'");
                            MessageBox.Show("Xóa thành công đề tài " + txt_tendt.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgr_danhsachdetai.DataSource = DataConnection.Danhsach(query_dsdetai).Tables[0];
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
            }else
            {
                MessageBox.Show("Bạn vui lòng nhập tên đề tài cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
