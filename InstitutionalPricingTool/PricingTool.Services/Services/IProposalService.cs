using PricingTool.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PricingTool.Services.Services
{
    public interface IProposalService
    {
        Task<IEnumerable<Proposal>> GetProposals();
    }
}
