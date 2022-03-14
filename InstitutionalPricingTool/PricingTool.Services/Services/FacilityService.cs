using PricingTool.Data;
using PricingTool.Models.DAO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PricingTool.Services.Services
{
    public class FacilityService : IFacilityService
    {
        private readonly IFacilityRepository _facilityRepository;
        public FacilityService(IFacilityRepository facilityRepository)
        {
            _facilityRepository = facilityRepository;
        }
        public async Task<IEnumerable<Facility>> GetFacilities(string proposalName)
        {
            return await _facilityRepository.GetFacilities(proposalName);
        }

        public async Task<Facility> GetFacility(string proposalName, string facilityName)
        {
            return await _facilityRepository.GetFacility(proposalName, facilityName);
        }
    }
}
