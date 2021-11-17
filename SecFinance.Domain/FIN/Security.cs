using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.Domain.FIN
{
    public class Security
    {
        public int Id { get; set; }

        public int SecurityNum { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string TypeDesc { get; set; }

        public string ApplicantCode { get; set; }

        public string DepeloperCode { get; set; }

        public string DeptCode { get; set; }

        public string DeptContact { get; set; }

        public string Development { get; set; }

        public DateTime Completion { get; set; }

        public string SecurityStatus { get; set; }

        public string ProjectType { get; set; }

        public string FileNum { get; set; }

        public string LocNum { get; set; }

    }
}
