using Microsoft.EntityFrameworkCore;
using PricingTool.Models.DAO;

namespace PricingTool.Data
{
    public class BaseRepository : DbContext
    {
        public BaseRepository(DbContextOptions<BaseRepository> options) 
            : base(options)
        {

        }

        public DbSet<Proposal> Proosals { get; set; }
        public DbSet<Facility> Facilities { get; set; }
    }
}
