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
    public class PolicyGroupingController : ControllerBase
    {


        private readonly ILogger<PolicyGroupingController> _logger;

        public PolicyGroupingController(ILogger<PolicyGroupingController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public PolicyGroupingDTO GetGrouping()
        {
            return new PolicyGroupingDTO();
        }

        [HttpGet]
        public IEnumerable<PolicyGroupingDTO> GetContents()
        {

            return new List<PolicyGroupingDTO>();
        }

        [HttpPost]
        public PolicyGroupingDTO CreatePolicy(PolicyGroupingDTO value)
        {
            // Add logic

            return value;
        }



        [HttpDelete("{id}")]
        public void DeletePGrouping(long id)
        {
            // Add logic
        }
    }
}
