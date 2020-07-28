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
    [Route("[controller]")]
    public class PolicyController : ControllerBase
    {


        private readonly ILogger<PolicyController> _logger;

        public PolicyController(ILogger<PolicyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public PolicyDTO GetPolicy()
        {
            var policy = new PolicyDTO();
            return policy;
        }

        [HttpGet]
        public IEnumerable<PolicyDTO> GetPolicies()
        {

            return new List<PolicyDTO>();
        }

        [HttpPost]
        public PolicyDTO CreatePolicy(PolicyDTO value)
        {
            // Add logic

            return value;
        }



        [HttpDelete("{id}")]
        public void DeletePolcy(long id)
        {
            // Add logic
        }
    }
}
