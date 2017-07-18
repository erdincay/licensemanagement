using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace LicenseManagement.DataModels
{
    [Table(Name = "license_data")]
    class LicenseData 
    {
        [PrimaryKey, Identity]
        [Column(Name = "customer_id"), NotNull]
        public int CustomerID { get; set; }

        [Column(Name = "customer_name"), NotNull]
        public string CustomerName { get; set; }

        [Column(Name = "license_amount")]
        public int LicenseAmount { get; set; }

        [Column(Name = "rent_fee")]
        public int RentFee { get; set; }
        
        [Column(Name = "last_maintenance")]
        public string LastMaintenance { get; set; }

        [Column(Name = "support_service")]
        public int SupportService { get; set; }

        [Column(Name = "license_keys")]
        public string LicenseKeys { get; set; }

        [Column(Name = "software_version")]
        public string SoftwareVersion { get; set; }

        [Column(Name = "contact_person")]
        public string ContactPerson { get; set; }

    }
}
