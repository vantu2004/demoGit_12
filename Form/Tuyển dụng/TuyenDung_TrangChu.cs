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

namespace Project_Windows_04
{
    public partial class TuyenDung_TrangChu : Form
    {
        TuyenDung_DAO NTD_DAO = new TuyenDung_DAO();
        public string IdCompany;

        public TuyenDung_TrangChu()
        {
            InitializeComponent();
        }

        private void TuyenDung_TrangChu_Load(object sender, EventArgs e)
        {
            uC_BangTin1.btn_dangTinTuyenDung.Hide();
            uC_BangTin1.btn_dangNhap.Hide();
            uC_BangTin1.btn_dangKy.Hide();
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
            }
        }

        public byte[] chuyenAnhSangByte(Image image)
        {
            // Tạo một MemoryStream để lưu trữ dữ liệu hình ảnh
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Lưu trữ hình ảnh vào MemoryStream
                image.Save(memoryStream, image.RawFormat);

                // Trả về mảng byte của dữ liệu hình ảnh
                return memoryStream.ToArray();
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
        }

        public void btn_hoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                Guid g = Guid.NewGuid();

                // Chuyển image sang byte để lưu vào csdl
                byte[] anh_byte = chuyenAnhSangByte(pbx_logoCongTy.Image);
                
                TuyenDung_Tin t = new TuyenDung_Tin(IdCompany, g.ToString(), "Employer", anh_byte, tbx_tenCongTy.Text, tbx_mangXaHoi.Text, cbx_diaChi_CongTy.Text,
                    cbx_nganhNghe.Text, tbx_tenCongViec.Text, Convert.ToDouble(tbx_luong.Text), cbx_kinhNghiem.Text, cbx_hinhThucLamViec.Text,
                    tbx_tenHR.Text, tbx_emailHR.Text, tbx_sdtHR.Text, cbx_viTriCongTac_HR.Text, dtpr_ngayDang.Value.ToShortDateString(),
                    dtpr_hanChot.Value.ToShortDateString(), rtbx_moTaCongViec.Text, rtbx_yeuCauUngVien.Text, rtbx_quyenLoi.Text);

                NTD_DAO.taoTin(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
