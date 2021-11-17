using SecFinance.Domain.FIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.DA.SecurityData
{
    public class SecurityRepo : Repository<Security>, ISecurityRepo
    {
        public SecurityRepo(SecCtx context) : base(context)
        {

        }
        public SecCtx SecContext
        {
            get { return _context as SecCtx; }
        }
    }
}
