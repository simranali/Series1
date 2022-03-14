using PricingTool.Models.DAO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PricingTool.Data
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly BaseRepository _baseRepository;

        public FacilityRepository(BaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task<IEnumerable<Facility>> GetFacilities(string proposalName)
        {
            return await _baseRepository.Facilities.FromSqlRaw("EXEC spPricingToolFacilities {0}", proposalName).ToListAsync();
        }

        public async Task<Facility> GetFacility(string proposalName, string facilityName)
        {
            var facility = await _baseRepository.Facilities.FromSqlRaw("EXEC spPricingToolFacilities {0}, {1}", proposalName, facilityName).ToListAsync();
            return facility.FirstOrDefault();            
        }
    }
}
