﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    internal class TuyenDung_DAO
    {
        dbConnection db = new dbConnection();

        public TuyenDung_DAO() { }

        public void dangKy(TuyenDung t, TaiKhoan tk)
        {
            string sqlQuery_NTD = string.Format("INSERT INTO NHATUYENDUNG(Id, UserType, Fname, Email, PhoneNTD, JobPos, Company, JobLocation, SocialNetwork) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
                , t.Id, t.UserType, t.TenHR, t.EmailHR, t.SdtHR, t.ViTriCongTacHR, t.TenCongTy, t.DiaChiCongTy, t.MangXaHoi);
            string sqlQuery_TK = string.Format("INSERT INTO TAIKHOAN(Id, UserType, UserName, UserPassword) VALUES ('{0}', '{1}', '{2}', '{3}')"
                , tk.Id, tk.UserType, tk.TenDangNhap, tk.MatKhau);

            db.thucThi_dangKy(sqlQuery_NTD, sqlQuery_TK);
        }

        public void taoTin(TuyenDung_Tin t)
        {
            string sqlQuery_taoTin = string.Format("INSERT INTO JobPostings(IdCompany, IdJobPostings, IconCompany, Job, PositionNeeded, Salary, Experience, WorkFormat, DatePosted, Deadline, JobDescription, Requirements, Benefit) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                t.IdCompany, t.IdJobPostings, t.LogoCongTy, t.NganhNghe, t.ViTriCanTuyen, t.Luong, t.KinhNghiem, t.HinhThucLamViec, t.NgayDang, t.HanChot, t.MoTaCongViec, t.YeuCau, t.LoiIch);

            db.thucThi_taoTin(sqlQuery_taoTin);
        }
    }
}
