using Microsoft.EntityFrameworkCore;

namespace IT3047C_FinalProject.Models
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext(DbContextOptions<FinalProjectContext> options)
            : base(options)
        { }

        public DbSet<Chloe> Chloe { get; set; }
        public DbSet<Shared> SharedHobbies { get; set; }
        public DbSet<Dakota> Dakotas { get; set; }
        public DbSet<RecHobbies> RecHobbies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RecConfig());
        }
    }
}
