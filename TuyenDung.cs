using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    internal class TuyenDung
    {
        private int idNguoiDung;
        private string kieuNguoiDung;
        private string tenHR;
        private string emailHR;
        private string sdtHR;
        private string viTriCongTacHR;
        private string tenCongTy;
        private string diaChiCongTy;
        private string mangXaHoi;

        public TuyenDung() { }
        public TuyenDung(int idNguoiDung, string kieuNguoiDung, string tenHR, string emailHR, string sdtHR, string viTriCongTacHR, string tenCongTy, string diaChiCongTy, string mangXaHoi)
        {
            IdNguoiDung = idNguoiDung;
            KieuNguoiDung = kieuNguoiDung;
            TenHR = tenHR;
            EmailHR = emailHR;
            SdtHR = sdtHR;
            ViTriCongTacHR = viTriCongTacHR;
            TenCongTy = tenCongTy;
            DiaChiCongTy = diaChiCongTy;
            MangXaHoi = mangXaHoi;
        }

        public int IdNguoiDung { get => idNguoiDung; set => idNguoiDung = value; }
        public string KieuNguoiDung { get => kieuNguoiDung; set => kieuNguoiDung = value; }
        public string TenHR { get => tenHR; set => tenHR = value; }
        public string EmailHR { get => emailHR; set => emailHR = value; }
        public string SdtHR { get => sdtHR; set => sdtHR = value; }
        public string ViTriCongTacHR { get => viTriCongTacHR; set => viTriCongTacHR = value; }
        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public string DiaChiCongTy { get => diaChiCongTy; set => diaChiCongTy = value; }
        public string MangXaHoi { get => mangXaHoi; set => mangXaHoi = value; }
    }
}
