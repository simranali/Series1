using PricingTool.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PricingTool.Services.Services
{
    public interface IFacilityService
    {
        Task<IEnumerable<Facility>> GetFacilities(string proposalName);
        Task<Facility> GetFacility(string proposalName, string facilityName);
    }
}
