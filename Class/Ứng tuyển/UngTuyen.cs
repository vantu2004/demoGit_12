using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    public class UngTuyen
    {
        private string idDangThucThi;
        private string userType;
        private string idCompany;
        private string idJobPostings;

        public UngTuyen() { }
        public UngTuyen(string idDangThucThi, string userType, string idCompany, string idJobPostings)
        {
            IdDangThucThi = idDangThucThi;
            UserType = userType;
            IdCompany = idCompany;
            IdJobPostings = idJobPostings;
        }

        public string IdDangThucThi { get => idDangThucThi; set => idDangThucThi = value; }
        public string UserType { get => userType; set => userType = value; }
        public string IdCompany { get => idCompany; set => idCompany = value; }
        public string IdJobPostings { get => idJobPostings; set => idJobPostings = value; }
    }
}
