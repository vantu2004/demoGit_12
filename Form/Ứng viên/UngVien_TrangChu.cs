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
        UngVien_DAO UV_DAO = new UngVien_DAO();
        public string Id;

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

        public void btn_hoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuyển image sang byte để lưu vào csdl
                byte[] anh_byte = chuyenAnhSangByte(pbx_avatar.Image);

                string gioiTinh;
                if (rbn_nam.Checked)
                    gioiTinh = "Nam";
                else
                    gioiTinh = "Nữ";

                DateTime dt = DateTime.Now;

                UngVien_Tin u = new UngVien_Tin(Id, anh_byte, tbx_tenUV.Text, dtpr_ngaySinhUV.Value.ToShortDateString(), gioiTinh, 
                    cbx_diaChiUV.Text, tbx_mangXaHoi.Text, tbx_sdtUV.Text, tbx_emaiUV.Text, cbx_viTriUngTuyen.Text, 
                    dt.ToString(), rtbx_mucTIeuNgheNghiep.Text, rtbx_hocVan.Text, rtbx_kinhNghiem.Text);

                UV_DAO.taoTin(u);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
