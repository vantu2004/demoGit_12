using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_Windows_04
{
    internal class dbConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public dbConnection() { }

        public void thucThi_dangKy(string sqlQuery, string sqlQuery_TK)
        {
            try
            {
                conn.Open();
                SqlCommand cmd_TK = new SqlCommand(sqlQuery_TK, conn);

                if (cmd_TK.ExecuteNonQuery() > 0)
                {
                    SqlCommand cmd_NTD = new SqlCommand(sqlQuery, conn);

                    if (cmd_NTD.ExecuteNonQuery() > 0)
                        MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public void thucThi_dangNhap(string sqlQuery)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (data.GetString(1) == "Employer")
                    {
                        string sqlQuery_NTD = string.Format("SELECT * FROM NHATUYENDUNG WHERE Id = '{0}'", data.GetString(0));
                        conn.Close();
                        thucThi_layDuLieu_NTD(sqlQuery_NTD);
                    }
                    else
                    {
                        string sqlQuery_UV = string.Format("SELECT * FROM UNGVIEN WHERE Id = '{0}'", data.GetString(0));
                        conn.Close();
                        thucThi_layDuLieu_UV(sqlQuery_UV);
                    }    
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public void thucThi_layDuLieu_NTD(string sqlQuery_NTD)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery_NTD, conn);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    TuyenDung t = new TuyenDung(data.GetString(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4), data.GetString(5), data.GetString(6), data.GetString(7), data.GetString(8));
                    TuyenDung_TrangChu TD_TC = new TuyenDung_TrangChu();
                    TD_TC.layDuLieu(t);
                    TD_TC.ShowDialog();
                }
                else
                    MessageBox.Show("Thông tin không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void thucThi_layDuLieu_UV(string sqlQuery_UV)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery_UV, conn);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    UngVien u = new UngVien(data.GetString(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4), data.GetString(5), data.GetString(6), data.GetString(7), data.GetString(8));
                    UngVien_TrangChu UV_TC = new UngVien_TrangChu();
                    UV_TC.layDuLieu(u);
                    UV_TC.ShowDialog();
                }
                else
                    MessageBox.Show("Thông tin không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
