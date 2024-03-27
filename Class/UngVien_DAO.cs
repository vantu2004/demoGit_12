﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    internal class UngVien_DAO
    {
        dbConnection db = new dbConnection();

        public UngVien_DAO() { }

        public void dangKy(UngVien uv, TaiKhoan tk)
        {
            string sqlQuery_UV = string.Format("INSERT INTO UNGVIEN(Id, UserType, Fname, Phone, BirthDate, Link, Email, Address_C, Gender) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
                , uv.Id, uv.UserType, uv.Ten, uv.Sdt, uv.NgaySinh, uv.MangXaHoi, uv.Email, uv.DiaChi, uv.GioiTinh);
            string sqlQuery_TK = string.Format("INSERT INTO TAIKHOAN(Id, UserType, UserName, UserPassword) VALUES ('{0}', '{1}', '{2}', '{3}')"
                , tk.Id, tk.UserType, tk.TenDangNhap, tk.MatKhau);

            db.thucThi_dangKy(sqlQuery_UV, sqlQuery_TK);
        }

        public void taoTin(UngVien_Tin u)
        {
            string sqlQuery_taoTin = string.Format("INSERT INTO CVs(Id, Avatar, JobPos, CareerGoal, Education, Experience, UploadDate) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                u.Id, u.AnhDaiDien, u.ViTriUngTuyen, u.MucTieuNgheNghiep, u.HocVan, u.KinhNghiem, u.NgayCapNhatCV);

            db.thucThi_taoTin(sqlQuery_taoTin);
        }
    }
}
