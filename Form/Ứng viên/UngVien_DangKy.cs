using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Windows_04
{
    public partial class UngVien_DangKy : Form
    {
        public UngVien_DangKy()
        {
            InitializeComponent();
        }

        private void btnThoatForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
