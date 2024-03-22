using System;
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
            //try
            //{
            //    conn.Open();

            //    if (tbx_matKhau_TD.Text == tbx_nhapLaiMatKhau_TD.Text)
            //    {
            //        Guid g = Guid.NewGuid();

            //        TaiKhoan tk = new TaiKhoan(g.ToString(), "Employer", tbx_tenDangNhap_TD.Text, tbx_matKhau_TD.Text);
            //        string sqlQuery_TK = string.Format("INSERT INTO TAIKHOAN(Id, UserType, UserName, UserPassword) VALUES ('{0}', '{1}', '{2}', '{3}')"
            //            , tk.Id, tk.UserType, tk.TenDangNhap, tk.MatKhau);
            //        SqlCommand cmd_TK = new SqlCommand(sqlQuery_TK, conn);

            //        if (cmd_TK.ExecuteNonQuery() > 0)
            //        {
            //            TuyenDung t = new TuyenDung(g.ToString(), "Employer", tbx_ten_HR.Text, tbx_email_HR.Text, tbx_sdt_HR.Text, cbx_viTriCongTac_HR.Text, tbx_ten_CongTy.Text, cbx_diaChi_CongTy.Text, tbx_mangXaHoi_CongTy.Text);
            //            string sqlQuery_NTD = string.Format("INSERT INTO NHATUYENDUNG(Id, UserType, Fname, Email, PhoneNTD, JobPos, Company, JobLocation, SocialNetwork) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')"
            //                , t.Id, t.UserType, t.TenHR, t.EmailHR, t.SdtHR, t.ViTriCongTacHR, t.TenCongTy, t.DiaChiCongTy, t.MangXaHoi);
            //            SqlCommand cmd_NTD = new SqlCommand(sqlQuery_NTD, conn);
            //            if (cbx_dongYDieuKhoan.Checked == true)
            //            {
            //                if (cmd_NTD.ExecuteNonQuery() > 0)
            //                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }    
            //            else
            //                MessageBox.Show("Bạn phải đồng ý điều khoản được đưa ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //        MessageBox.Show("Bạn phải nhập lại đúng mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }
    }
}
