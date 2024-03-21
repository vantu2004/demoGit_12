using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    internal class TaiKhoan
    {
        private int idNguoiDung;
        private string kieuNguoiDung;
        private string tenDangNhap;
        private string matKhau;

        public TaiKhoan() { }
        public TaiKhoan (int idNguoiDung, string kieuNguoiDung, string tenDangNhap, string matKhau)
        {
            IdNguoiDung = idNguoiDung;
            KieuNguoiDung = kieuNguoiDung;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }

        public int IdNguoiDung { get => idNguoiDung; set => idNguoiDung = value; }
        public string KieuNguoiDung { get => kieuNguoiDung; set => kieuNguoiDung = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
