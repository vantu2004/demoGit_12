using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using static DevExpress.Xpo.Helpers.CommandChannelHelper;

namespace Project_Windows_04
{
    internal class dbConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public dbConnection() { }

        public void thucThi_dangKy(string sqlQuery_NTD_UV, string sqlQuery_TK)
        {
            try
            {
                conn.Open();
                SqlCommand cmd_TK = new SqlCommand(sqlQuery_TK, conn);

                if (cmd_TK.ExecuteNonQuery() > 0)
                {
                    SqlCommand cmd_NTD_UV = new SqlCommand(sqlQuery_NTD_UV, conn);

                    if (cmd_NTD_UV.ExecuteNonQuery() > 0)
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
                    TD_TC.IdCompany = t.Id;
                    TD_TC.ShowDialog();
                    TD_TC.btn_hoanTat.Click += TD_TC.btn_hoanTat_Click;
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
                    UV_TC.Id = u.Id;
                    UV_TC.ShowDialog();
                    UV_TC.btn_hoanTat.Click += UV_TC.btn_hoanTat_Click;
                }
                else
                    MessageBox.Show("Thông tin không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void thucThi_taoTin(string sqlQuery_taoTin)
        {
            //try
            {
                {
                    conn.Open();

                    SqlCommand cmd_TT = new SqlCommand(sqlQuery_taoTin, conn);

                    if (cmd_TT.ExecuteNonQuery() > 0)
                        MessageBox.Show("Tạo tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SqlDataReader data = cmd_TT.ExecuteReader();

                    //if (data.Read() == true)
                    //{
                    //    MessageBox.Show("Tạo tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //    byte[] imageData = (byte[])data.GetValue(2);
                    //    Image image = ByteArrayToImage(imageData);
                    //    temp01 t = new temp01();
                    //    t.pbx_temp.Image = image;
                    //    t.ShowDialog();
                    //}
                    //else
                    //    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //finally
            {
                conn.Close();
            }
        }

        //static Image chuyenByteSangAnh(byte[] imageData)
        //{
        //    using (MemoryStream ms = new MemoryStream(imageData))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}
    }
}
