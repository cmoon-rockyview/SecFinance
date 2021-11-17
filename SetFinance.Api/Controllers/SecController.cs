using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecFinance.DA.SecurityData;
using SecFinance.Domain.FIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetFinance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecController : ControllerBase
    {
        ISecUnit _SecUnit;

        public SecController(ISecUnit unit)
        {
            _SecUnit = unit;
        }

        [HttpGet]
        public async Task<IEnumerable<Security>> GetSecurities()
        {
            return await _SecUnit.SecurityRepo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Security> GetSecurity(int id)
        {
            return await _SecUnit.SecurityRepo.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Security>> AddSecurity([FromBody] Security security)
        {
            var newSec = await _SecUnit.SecurityRepo.AddAsync(security);
            await _SecUnit.CompleteAsync();
            return newSec;
        }

        [HttpPut]
        public async Task<ActionResult<Security>> UpdateSecurity([FromBody] Security security)
        {  
            await _SecUnit.SecurityRepo.UpdateAsync(security);
            await _SecUnit.CompleteAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSecurity(int id)
        {
            var security = await _SecUnit.SecurityRepo.GetAsync(id);

            if (security == null)            
                return NotFound();            

            await _SecUnit.SecurityRepo.RemoveAync(security);
            await _SecUnit.CompleteAsync();

            return NoContent();
        }

    }
}
