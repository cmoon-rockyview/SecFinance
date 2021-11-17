using SecFinance.Domain.FIN;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecFinance.App.Services
{
    public interface ISecurityService
    {
        Task<IEnumerable<Security>> GetSecurities();
    }
}