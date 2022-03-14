using PricingTool.Data;
using PricingTool.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PricingTool.Services.Services
{
    public class ProposalService : IProposalService
    {
        private readonly IProposalRepository _proposalRepository;

        public ProposalService(IProposalRepository proposalRepository)
        {
            _proposalRepository = proposalRepository;
        }
        public async Task<IEnumerable<Proposal>> GetProposals()
        {
           return await _proposalRepository.GetProposals();
        }
    }
}
