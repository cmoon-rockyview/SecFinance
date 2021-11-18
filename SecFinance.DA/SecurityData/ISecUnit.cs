using System;
using System.Threading.Tasks;

namespace SecFinance.DA.SecurityData
{
    public interface ISecUnit : IDisposable
    {
        ISecurityRepo SecurityRepo { get; }

        void Complete();
        Task CompleteAsync();
        
    }
}