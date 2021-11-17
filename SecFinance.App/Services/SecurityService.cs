using SecFinance.Domain.FIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace SecFinance.App.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly HttpClient _httpClient;

        public SecurityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Security>> GetSecurities()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Security>>("http://localhost:5000/api/sec");
        }

    }
}
