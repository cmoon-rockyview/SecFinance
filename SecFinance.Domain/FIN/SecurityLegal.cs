using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.Domain.FIN
{
    public class SecurityLegal
    {
        public int Id { get; set; }

        public string Roll { get; set; }

        public string Quarter { get; set; }

        public string Section { get; set; }

        public string Township { get; set; }

        public string Range { get; set; }

        public string Lot { get; set; }

        public string Block { get; set; }
        public string Plan { get; set; }

    }
}
