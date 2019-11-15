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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BBMachine>().HasOne(s => s.currentstate);
            modelBuilder.Entity<Batch>().HasOne(s => s.machine);
            modelBuilder.Entity<DataReading>().HasOne(s => s.batchid);
        }

        public DbSet<BBMachine> machines { get; set; }
        public DbSet<MachineState> statetypes { get; set; }
        public DbSet<ProductType> producttypes { get; set; }
        public DbSet<DataReading> datareadings { get; set; }
        public DbSet<Batch> batches { get; set; }
    }
}