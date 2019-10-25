using Microsoft.EntityFrameworkCore;
using MVCEngiBeering.Models;

namespace MVCEngiBeering.Data
{
    public class MvcEngibeeringContext : DbContext
    {
        
        public MvcEngibeeringContext(DbContextOptions<MvcEngibeeringContext> options)
                : base(options)
            {
                
            }

        public DbSet<BBMachine> machines { get; set; }
        public DbSet<MachineState> statetypes { get; set; }
        public DbSet<ProductType> producttypes { get; set; }
        
    }
}