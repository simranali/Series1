using PricingTool.Models.DAO;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace PricingTool.Data
{
    public class ProposalRepository : IProposalRepository
    {
        private readonly BaseRepository _baseRepository;

        public ProposalRepository(BaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<IEnumerable<Proposal>> GetProposals()
        {
            return await _baseRepository.Proosals.FromSqlRaw("Exec spPricingToolProposals").ToListAsync();
        }
    }
}
