﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IT3047C_FinalProject.Models
{
    internal class SharedConfig : IEntityTypeConfiguration<Shared>
    {
        public void Configure(EntityTypeBuilder<Shared> entity)
        {
            entity.HasData(
                new Shared { SharedHobbyId = 1, SharedHobbyName = "Gaming" },
                new Shared { SharedHobbyId = 2, SharedHobbyName = "Building" }
                );
        }
    }
}
