using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PolicyManagement.API.DTO;

namespace PolicyManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PolicyVersionController : ControllerBase
    {


        private readonly ILogger<PolicyVersionController> _logger;

        public PolicyVersionController(ILogger<PolicyVersionController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public PolicyVersionDTO GetPolicyVersion()
        {
            var value = new PolicyVersionDTO();
            return value;
        }

        [HttpGet]
        public IEnumerable<PolicyVersionDTO> GetPolicyVersions()
        {

            return new List<PolicyVersionDTO>();
        }

        [HttpPost]
        public PolicyVersionDTO CreateVersion(PolicyVersionDTO value)
        {
            // Add logic

            return value;
        }



        [HttpDelete("{id}")]
        public void DeleteVersion(long id)
        {
            // Add logic
        }
    }
}
