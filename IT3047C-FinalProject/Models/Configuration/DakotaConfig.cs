using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IT3047C_FinalProject.Models
{
    public class DakotaConfig : IEntityTypeConfiguration<Dakota>
    {
        public void Configure(EntityTypeBuilder<Dakota> entity)
        {
            entity.HasData(
                new Dakota { HobbyId = 1, HobbyName = "Hiking", HobbyType = "Hiking Trails, Camping, and Outdoor Activies" },
                new Dakota { HobbyId = 2, HobbyName = "Gaming", HobbyType = "RPG Games, Action Games, and Platforming Games" },
                new Dakota { HobbyId = 3, HobbyName = "Swimming", HobbyType = "Freestyle, Breaststroke, and Relay Races" },
                new Dakota { HobbyId = 4, HobbyName = "Building", HobbyType = "3D Printing, Crafts, and Modeling" },
                new Dakota { HobbyId = 5, HobbyName = "Fishing", HobbyType = "Traditional Catch and Release" }
                );
        }
    }
}

