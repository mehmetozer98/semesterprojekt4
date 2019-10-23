using Microsoft.EntityFrameworkCore;

namespace MVCEngiBeering.Models
{
    public class MvcMachineContext : DbContext
    {
        
        public MvcMachineContext(DbContextOptions<MvcMachineContext> options)
                : base(options)
            {
                
            }

            public System.Data.Entity.DbSet<BBMachine> Machine { get; set; }
        
    }
}