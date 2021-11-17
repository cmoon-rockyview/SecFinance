using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.DA.SecurityData
{
    public interface IUnitOfWork : IDisposable
    {
        Task CompleteAsync();
        void Complete();

        ISecurityRepo SecurityRepo { get; }
    }
}
