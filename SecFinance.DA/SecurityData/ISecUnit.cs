using System.Threading.Tasks;

namespace SecFinance.DA.SecurityData
{
    public interface ISecUnit
    {
        ISecurityRepo SecurityRepo { get; }




        void Complete();
        Task CompleteAsync();
        void Dispose();
    }
}