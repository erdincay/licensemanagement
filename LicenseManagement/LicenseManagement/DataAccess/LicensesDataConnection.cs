using LicenseManagement.DataModels;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseManagement.DataAccess
{
    class LicensesDataConnection : LinqToDB.Data.DataConnection
    {
        public LicensesDataConnection() : base("LICDB") { }

        public ITable<LicenseData> LicenseData { get { return GetTable<LicenseData>(); } }
    }
}
