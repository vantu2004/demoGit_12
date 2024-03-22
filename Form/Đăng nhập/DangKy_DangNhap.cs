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
using Microsoft.IdentityModel.Tokens;

namespace Project_Windows_04
{
    public partial class DangKy_DangNhap : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        dbConnection db = new dbConnection();
        public DangKy_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            TuyenDung_UngVien TD_UV = new TuyenDung_UngVien();
            TD_UV.ShowDialog();
        }

        private void DangKy_DangNhap_Load(object sender, EventArgs e)
        {

        }
        private void btn_dangNhap_Click_1(object sender, EventArgs e)
        {
            string tdn = tbx_tenDangNhap.Text;
            string mk = tbx_matKhau.Text;

            string sqlQuery = string.Format("SELECT * FROM TAIKHOAN WHERE UserName = '{0}' AND UserPassword = '{1}'", tdn, mk);

            db.thucThi_dangNhap(sqlQuery);
        }
    }
}
