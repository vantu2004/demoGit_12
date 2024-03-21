using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    internal class UngVien
    {
        private int idNguoiDung;
        private string kieuNguoiDung;
        private string ten;
        private string sdt;
        private DateTime ngaySinh;
        private string mangXaHoi;
        private string email;
        private string diaChi;
        private string gioiTinh;

        public UngVien() { }
        public UngVien(int idNguoiDung, string kieuNguoiDung, string ten, string sdt, DateTime ngaySinh, string mangXaHoi, string email, string diaChi, string gioiTinh)
        {
            IdNguoiDung = idNguoiDung;
            KieuNguoiDung = kieuNguoiDung;
            Ten = ten;
            Sdt = sdt;
            NgaySinh = ngaySinh;
            MangXaHoi = mangXaHoi;
            Email = email;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
        }

        public int IdNguoiDung { get => idNguoiDung; set => idNguoiDung = value; }
        public string KieuNguoiDung { get => kieuNguoiDung; set => kieuNguoiDung = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string MangXaHoi { get => mangXaHoi; set => mangXaHoi = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
