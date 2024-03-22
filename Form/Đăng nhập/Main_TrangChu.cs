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
    public partial class Main_TrangChu : Form
    {
        public Main_TrangChu()
        {
            InitializeComponent();
        }

        public void btn_dangKy_Click(object sender, EventArgs e)
        {
            TuyenDung_UngVien TD_UV = new TuyenDung_UngVien();
            TD_UV.ShowDialog();
        }
        public void btn_dangNhap_Click(object sender, EventArgs e)
        {
            DangKy_DangNhap DK_DN = new DangKy_DangNhap();
            DK_DN.ShowDialog();
        }
        private void Main_TrangChu_Load(object sender, EventArgs e)
        {
            UC_Main_TrangChu.btn_dangKy.Click += btn_dangKy_Click;
            UC_Main_TrangChu.btn_dangNhap.Click += btn_dangNhap_Click;
        }
    }
}
