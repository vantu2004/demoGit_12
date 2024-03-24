﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    internal class TuyenDung_Tin
    {
        private string id;
        private string userType;
        private Image logoCongTy;
        private string tenCongTy;
        private string mangXaHoi;
        private string diaChi;
        private string nganhNghe;
        private string viTriCanTuyen;
        private double luong;
        private string kinhNghiem;
        private string hinhThucLamViec;
        private string tenHR;
        private string emailHR;
        private string sdtHR;
        private string viTriCongTacHR;
        private string ngayDang;
        private string hanChot; 
        private string moTaCongViec;
        private string yeuCau;
        private string loiIch;

        public TuyenDung_Tin() { }
        public TuyenDung_Tin( string id, string userType, Image logoCongTy, string tenCongTy, string mangXaHoi, string diaChi, string nganhNghe, string viTriCanTuyen, double luong, string kinhNghiem, 
            string hinhThucLamViec, string tenHR, string emailHR, string sdtHR, string viTriCongTacHR, string ngayDang, string hanChot, string moTaCongViec, string yeuCau, string loiIch)
        {
            Id = id;
            UserType = userType;
            LogoCongTy = logoCongTy;
            TenCongTy = tenCongTy;
            MangXaHoi = mangXaHoi;
            DiaChi = diaChi;
            NganhNghe = nganhNghe;
            ViTriCanTuyen = viTriCanTuyen;
            Luong = luong;
            KinhNghiem = kinhNghiem;
            HinhThucLamViec = hinhThucLamViec;
            TenHR = tenHR;
            EmailHR = emailHR;
            SdtHR = sdtHR;
            ViTriCongTacHR = viTriCongTacHR;
            NgayDang = ngayDang;
            HanChot = hanChot;
            MoTaCongViec = moTaCongViec;
            YeuCau = yeuCau;
            LoiIch = loiIch;
        }

        public string Id { get => id; set => id = value; }
        public string UserType { get => userType; set => userType = value; }
        public Image LogoCongTy { get => logoCongTy; set => logoCongTy = value; }
        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public string MangXaHoi { get => mangXaHoi; set => mangXaHoi = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NganhNghe { get => nganhNghe; set => nganhNghe = value; }
        public string ViTriCanTuyen { get => viTriCanTuyen; set => viTriCanTuyen = value; }
        public double Luong { get => luong; set => luong = value; }
        public string KinhNghiem { get => kinhNghiem; set => kinhNghiem = value; }
        public string HinhThucLamViec { get => hinhThucLamViec; set => hinhThucLamViec = value; }
        public string TenHR { get => tenHR; set => tenHR = value; }
        public string EmailHR { get => emailHR; set => emailHR = value; }
        public string SdtHR { get => sdtHR; set => sdtHR = value; }
        public string ViTriCongTacHR { get => viTriCongTacHR; set => viTriCongTacHR = value; }
        public string NgayDang { get => ngayDang; set => ngayDang = value; }
        public string HanChot { get => hanChot; set => hanChot = value; }
        public string MoTaCongViec { get => moTaCongViec; set => moTaCongViec = value; }
        public string YeuCau { get => yeuCau; set => yeuCau = value; }
        public string LoiIch { get => loiIch; set => loiIch = value; }
    }
}