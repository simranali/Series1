using PricingTool.Models.DAO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PricingTool.Data
{
    public interface IProposalRepository
    {
        Task<IEnumerable<Proposal>> GetProposals();
    }
}
