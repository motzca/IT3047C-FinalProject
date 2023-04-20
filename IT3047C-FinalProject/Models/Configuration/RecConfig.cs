using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IT3047C_FinalProject.Models
{
    internal class RecConfig : IEntityTypeConfiguration<RecHobbies>
    {
        public void Configure(EntityTypeBuilder<RecHobbies> entity)
        {
            entity.HasData(
                new RecHobbies { Id = 1, Name = "Example here", hobbyType = "Computers", recommendedHobby = "Practice coding" }
                );
        }
    }
}
