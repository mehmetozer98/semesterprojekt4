using Microsoft.EntityFrameworkCore;

namespace MVCEngiBeering.Models
{
    public class MvcMachineContext : DbContext
    {
        
        public MvcMachineContext(DbContextOptions<MvcMachineContext> options)
                : base(options)
            {
                
            }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            => optionsBuilder.UseNpgsql(
//                "Host='tek-mmmi-db0a.tek.c.sdu.dk';Database='si3_2019_group_3_db';Username='si3_2019_group_3';Password='sox6.genets'");

        public DbSet<BBMachine> machines { get; set; }
        
    }
}