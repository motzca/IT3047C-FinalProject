using Microsoft.EntityFrameworkCore;

namespace IT3047C_FinalProject.Models.DataLayer
{
    public class FinalProjectContext : DbContext 
    {
        public FinalProjectContext(DbContextOptions<FinalProjectContext> options) : base(options) { }
    }
}
