using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraEditors;
using static DevExpress.Skins.SolidColorHelper;

namespace Project_Windows_04
{
    public partial class TuyenDung_TrangChu : Form
    {
        TuyenDung_DAO NTD_DAO = new TuyenDung_DAO();
        TuyenDung NTD = new TuyenDung();
        Xuat_ThongTin xuat_TT = new Xuat_ThongTin();
        public string IdCompany;
        private string linkAnh;
        public TuyenDung_TrangChu()
        {
            InitializeComponent();
        }

        private void TuyenDung_TrangChu_Load(object sender, EventArgs e)
        {
            UC_BangTin_NTD.btn_dangTinTuyenDung.Hide();
            UC_BangTin_NTD.btn_dangNhap.Hide();
            UC_BangTin_NTD.btn_dangKy.Hide();

            NTD_DAO.load_tinTuyenDung(UC_BangTin_NTD.flpl_danhSachTinTuyenDung, NTD.Id, NTD.UserType);
        }

        private void pbx_logoCongTy_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Tạo một đối tượng hình ảnh từ tệp được chọn
                Image image = Image.FromFile(ofd.FileName);

                // Thiết lập hình ảnh cho PictureBox và điều chỉnh SizeMode
                pbx_logoCongTy.Image = image;
                pbx_logoCongTy.SizeMode = PictureBoxSizeMode.StretchImage;
                this.linkAnh = ofd.FileName;
            }
        }

        public void layDuLieu(TuyenDung NTD)
        {
            tbx_tenCongTy.Text = NTD.TenCongTy;
            tbx_mangXaHoi.Text = NTD.MangXaHoi;
            cbx_diaChi_CongTy.Text = NTD.DiaChiCongTy;
            tbx_tenHR.Text = NTD.TenHR;
            tbx_emailHR.Text = NTD.EmailHR;
            tbx_sdtHR.Text = NTD.SdtHR;
            cbx_viTriCongTac_HR.Text = NTD.ViTriCongTacHR;
            if (this.linkAnh != null)
            {
                pbx_logoCongTy.Image = Image.FromFile(this.linkAnh);
            }
            
            this.NTD = NTD;
        }

        public void btn_hoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                Guid g = Guid.NewGuid();

                MessageBox.Show(linkAnh);
                TuyenDung_Tin t = new TuyenDung_Tin(IdCompany, g.ToString(), "Employer", linkAnh, tbx_tenCongTy.Text, tbx_mangXaHoi.Text, cbx_diaChi_CongTy.Text,
                    cbx_nganhNghe.Text, tbx_tenCongViec.Text, Convert.ToDouble(tbx_luong.Text), cbx_kinhNghiem.Text, cbx_hinhThucLamViec.Text,
                    tbx_tenHR.Text, tbx_emailHR.Text, tbx_sdtHR.Text, cbx_viTriCongTac_HR.Text, dtpr_ngayDang.Value.ToShortDateString(),
                    dtpr_hanChot.Value.ToShortDateString(), rtbx_moTaCongViec.Text, rtbx_yeuCauUngVien.Text, rtbx_quyenLoi.Text);

                UC_BangTin_NTD.flpl_danhSachTinTuyenDung.Controls.Add(xuat_TT.them_tinTuyenDung(t, t.IdCompany, t.UserType));

                NTD_DAO.taoTin(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
