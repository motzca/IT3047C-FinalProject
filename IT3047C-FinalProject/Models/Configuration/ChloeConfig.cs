using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IT3047C_FinalProject.Models
{
    public class ChloeConfig : IEntityTypeConfiguration<Chloe>
    {
        public void Configure(EntityTypeBuilder<Chloe> entity)
        {
            entity.HasData(
                new Chloe { HobbyId = 1, HobbyName = "Crafting", HobdyType = "Journaling, scrap booking, knitting" }
                );
        }
    }
}
