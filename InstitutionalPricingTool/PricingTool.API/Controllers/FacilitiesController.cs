using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PricingTool.Models.DAO;
using PricingTool.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PricingTool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilitiesController : ControllerBase
    {
        private readonly IFacilityService _facilityService;
        private readonly ILogger<FacilitiesController> _logger;

        public FacilitiesController(IFacilityService facilityService, ILogger<FacilitiesController> logger)
        {
            _facilityService = facilityService;
            _logger = logger;
        }
        // GET api/<ProposalController>/proposal1
        [HttpGet("{proposalName}")]
        public async Task<IEnumerable<Facility>> GetData(string proposalName)
        {
            _logger.LogInformation("Fetching Facility data");
            var facilities = await _facilityService.GetFacilities(proposalName);
            return facilities;
        }
        // GET api/<ProposalController>/proposal1
        [HttpGet("{proposalName}/{facilityName}")]
        public async Task<Facility> GetData(string proposalName, string facilityName)
        {
            _logger.LogInformation("Fetching Facility data by facilityName");
            var facility = await _facilityService.GetFacility(proposalName, facilityName);
            return facility;
        }
    }
}
