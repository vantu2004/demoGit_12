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
    public partial class DangKy_DangNhap : Form
    {
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
    }
}
