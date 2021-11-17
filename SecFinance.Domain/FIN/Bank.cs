using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.Domain.FIN
{
    public class Bank
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLast { get; set; }

        public string Telephone { get; set; }

    }
}
