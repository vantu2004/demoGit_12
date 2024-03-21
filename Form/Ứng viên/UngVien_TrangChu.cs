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

namespace Project_Windows_04
{
    public partial class UngVien_TrangChu : Form
    {
        public UngVien_TrangChu()
        {
            InitializeComponent();
        }

        private void UngVien_TrangChu_Load(object sender, EventArgs e)
        {
            uC_BangTin1.btn_dangTinTuyenDung.Hide();
            uC_BangTin1.btn_dangNhap.Hide();
            uC_BangTin1.btn_dangKy.Hide();
        }
    }
}
