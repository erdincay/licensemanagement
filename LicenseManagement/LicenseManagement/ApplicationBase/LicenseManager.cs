using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Common;
using LicenseManagement.DataModels;
using LicenseManagement.DataAccess;
using System.Data;

namespace LicenseManagement.ApplicationBase
{
    class LicenseManager
    {

        public LicenseManager()
        {

        }

        public void addLicense(LicenseData ld)
        {
            using (var db = new LicensesDataConnection())
            {
                db.Insert(ld);
            }
        }

        public void updateLicense(LicenseData ld)
        {
            using (var db = new LicensesDataConnection())
            {
                db.Update(ld);
            }
        }

        public List<LicenseData> getLicensesAsList()
        {
            using (var db = new LicensesDataConnection())
            {
                var query = from l in db.LicenseData
                            orderby l.CustomerID ascending
                            select l;

                return query.ToList();
            }
        }

        public List<LicenseData> getLicensesAsList(String customerNameFilter)
        {
            using (var db = new LicensesDataConnection())
            {
                var query = from l in db.LicenseData
                            where l.CustomerName.Contains(customerNameFilter)
                            orderby l.CustomerID ascending
                            select l;

                return query.ToList();
            }
        }

        public LicenseData getLicense(int customerID)
        {
            using (var db = new LicensesDataConnection())
            {
                var ld = (from l in db.LicenseData
                         where l.CustomerID == customerID 
                         select l).FirstOrDefault();

                return ld;
            }
        }

        public void deleteLicense(int customerID)
        {
            using (var db = new LicensesDataConnection())
            {
                db.LicenseData.Where(ld => ld.CustomerID.Equals(customerID)).Delete();
            }
        }
    }

}
