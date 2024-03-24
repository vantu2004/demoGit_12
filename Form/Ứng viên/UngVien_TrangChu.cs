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

namespace Project_Windows_04
{
    public partial class UngVien_TrangChu : Form
    {
        public UngVien_TrangChu()
        {
            InitializeComponent();
        }

        private void UngVien_TrangChu_Load(object sender, EventArgs e)
        {
            uC_BangTin1.btn_dangTinTuyenDung.Hide();
            uC_BangTin1.btn_dangNhap.Hide();
            uC_BangTin1.btn_dangKy.Hide();
        }

        public void layDuLieu(UngVien UV)
        {
            tbx_tenUV.Text = UV.Ten;
            dtpr_ngaySinhUV.Value = Convert.ToDateTime(UV.NgaySinh);
            if (UV.GioiTinh == "Nam")
                rbn_nam.Checked = true;
            else
                rbn_nu.Checked = true;
            cbx_diaChiUV.Text = UV.DiaChi;
            tbx_mangXaHoi.Text = UV.MangXaHoi;
            tbx_sdtUV.Text = UV.Sdt;
            tbx_emaiUV.Text = UV.Email;
        }

        private void pbx_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Tạo một đối tượng hình ảnh từ tệp được chọn
                Image image = Image.FromFile(ofd.FileName);

                // Thiết lập hình ảnh cho PictureBox và điều chỉnh SizeMode
                pbx_avatar.Image = image;
                pbx_avatar.SizeMode = PictureBoxSizeMode.StretchImage;

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
    }
}
