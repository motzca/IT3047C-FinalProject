using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IT3047C_FinalProject.Models
{
    public class ChloeConfig : IEntityTypeConfiguration<Chloe>
    {
        public void Configure(EntityTypeBuilder<Chloe> entity)
        {
            entity.HasData(
                new Chloe { HobbyId = 1, HobbyName = "Crafting", HobdyType = "Journaling, scrapbooking, and knitting" },
                new Chloe { HobbyId = 2, HobbyName = "Gaming", HobdyType = "Hidden Object Games, Slice of Life Games, and Story Games" },
                new Chloe { HobbyId = 3, HobbyName = "Reading", HobdyType = "Thriller Novels, Slice of Life Novels, and Fantasy Novels" },
                new Chloe { HobbyId = 4, HobbyName = "Building", HobdyType = "Lego sets" }
                );
        }
    }
}
