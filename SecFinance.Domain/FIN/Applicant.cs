using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.Domain.FIN
{
    public class Applicant
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public  string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }



    }
}
