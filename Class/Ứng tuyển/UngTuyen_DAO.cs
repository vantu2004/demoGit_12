using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows_04
{
    public class UngTuyen_DAO
    {
        dbConnection db = new dbConnection();

        public UngTuyen_DAO() { }

        public void ungTuyen(UngTuyen UT)
        {
            string sqlQuery_UT = string.Format("INSERT INTO Applications(IdCompany, IdJobPostings, IdCandidate) VALUES ('{0}', '{1}', '{2}')"
                , UT.IdCompany, UT.IdJobPostings, UT.IdDangThucThi);

            // tận dụng hàm thucThi_taoTin_chinhSuaTin
            db.thucThi_taoTin_chinhSuaTin(sqlQuery_UT);
        }
    }
}
