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
    public partial class ChiTietTinTuyenDung : Form
    {
        public UngTuyen UT = new UngTuyen();
        private UngTuyen_DAO UT_DAO = new UngTuyen_DAO();

        public ChiTietTinTuyenDung()
        {
            InitializeComponent();
        }

        private void Btn_ungTuyen_Click(object sender, EventArgs e)
        {
            if (UT.UserType == "Employer")
                MessageBox.Show("You are the employer!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (UT.UserType == "null")
                MessageBox.Show("You must log in or sign up!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                UT_DAO.ungTuyen(UT);
        }
    }
}
