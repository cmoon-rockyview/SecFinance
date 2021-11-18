using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.DA.SecurityData
{
    public class SecUnit : ISecUnit
    {
        private SecCtx _context;

        public SecUnit(SecCtx context)
        {
            _context = context;

            SecurityRepo = new SecurityRepo(_context);
        }

        public ISecurityRepo SecurityRepo { get; private set; }

        public async Task CompleteAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

        }

        public void Complete()
        {
            try
            {
                _context.SaveChanges();
            }

            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
