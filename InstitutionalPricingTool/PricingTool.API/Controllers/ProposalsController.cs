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
    public class ProposalsController : ControllerBase
    {
        private readonly IProposalService _proposalService;
        private readonly ILogger<ProposalsController> _logger;

        public ProposalsController(IProposalService proposalService, ILogger<ProposalsController> logger)
        {
            _proposalService = proposalService;
            _logger = logger;
        }
        // GET: api/<ProposalController>
        [HttpGet]
        public async Task<IEnumerable<Proposal>> GetData()
        {
            _logger.LogInformation("Fetching Proposal data");
            return await _proposalService.GetProposals();
        }
    }
}
