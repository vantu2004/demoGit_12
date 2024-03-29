using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace Project_Windows_04
{
    public class Xuat_ThongTin
    {
        private string Id;
        private string userType;
        public Xuat_ThongTin() { }

        public UC_TinTuyenDung them_tinTuyenDung(TuyenDung_Tin t, string Id, string userType)
        {
            UC_TinTuyenDung UC_tinTuyenDung = new UC_TinTuyenDung();

            UC_tinTuyenDung.lbl_IdCompany.Text = t.IdCompany;
            UC_tinTuyenDung.lbl_IdJobPostings.Text = t.IdJobPostings;
            UC_tinTuyenDung.lbl_tenCongViec.Text = t.TenCongViec;
            UC_tinTuyenDung.pbx_logoCongTy.Image = Image.FromFile(t.LogoCongTy);
            UC_tinTuyenDung.lbl_tenCongTy.Text = t.TenCongTy;
            UC_tinTuyenDung.lbl_luong.Text = t.Luong.ToString();
            UC_tinTuyenDung.lbl_nganhNghe.Text = t.NganhNghe;
            UC_tinTuyenDung.lbl_kinhNghiem.Text = t.KinhNghiem;
            UC_tinTuyenDung.lbl_hinhThucLamViec.Text = t.HinhThucLamViec;
            UC_tinTuyenDung.lbl_diaChi.Text = t.DiaChi;

            this.Id = Id;
            this.userType = userType;

            UC_tinTuyenDung.Click += UC_tinTuyenDung_Click;

            return UC_tinTuyenDung;
        }

        private void UC_tinTuyenDung_Click(object sender, EventArgs e)
        {
            UC_TinTuyenDung myObject = sender as UC_TinTuyenDung;
            ChiTietTinTuyenDung chiTiet_tin = new ChiTietTinTuyenDung();
            UngTuyen UT = new UngTuyen(this.Id, this.userType, myObject.lbl_IdCompany.Text, myObject.lbl_IdJobPostings.Text);
            chiTiet_tin.UT = UT;
            chiTiet_tin.ShowDialog();
        }
    }
}
