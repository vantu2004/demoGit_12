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

        private void pbx_logoCongTy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Tạo một đối tượng hình ảnh từ tệp được chọn
                Image image = Image.FromFile(ofd.FileName);

                // Thiết lập hình ảnh cho PictureBox và điều chỉnh SizeMode
                pbx_logoCongTy.Image = image;
                pbx_logoCongTy.SizeMode = PictureBoxSizeMode.StretchImage;

                // Chuyển image sang byte để lưu vào csdl
                chuyenAnhSangByte(image);
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
            tbx_viTriCongTacHR.Text = NTD.ViTriCongTacHR;
        }
    }
}
