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
using System.Windows.Input;
using DevExpress.Utils.Gesture;
using System.Security.Principal;
using static DevExpress.XtraEditors.XtraInputBox;

namespace Project_Windows_04
{
    public partial class TuyenDung_DangKy : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TuyenDung_DAO NTD_DAO = new TuyenDung_DAO();
        public TuyenDung_DangKy()
        {
            InitializeComponent();
        }

        private void TuyenDung_DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btn_hoanTat_Click(object sender, EventArgs e)
        {
            if (tbx_matKhau_TD.Text == tbx_nhapLaiMatKhau_TD.Text)
            {
                Guid g = Guid.NewGuid();

                TuyenDung t = new TuyenDung(g.ToString(), "Employer", tbx_ten_HR.Text, tbx_email_HR.Text, tbx_sdt_HR.Text, cbx_viTriCongTac_HR.Text, tbx_ten_CongTy.Text, cbx_diaChi_CongTy.Text, tbx_mangXaHoi_CongTy.Text);
                TaiKhoan tk = new TaiKhoan(g.ToString(), "Employer", tbx_tenDangNhap_TD.Text, tbx_matKhau_TD.Text);
                if (cbx_dongYDieuKhoan.Checked == true)
                    NTD_DAO.dangKy(t, tk);
                else
                    MessageBox.Show("Bạn phải đồng ý điều khoản được đưa ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bạn phải nhập lại đúng mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
