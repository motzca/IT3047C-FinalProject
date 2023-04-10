﻿// <auto-generated />
using IT3047C_FinalProject.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IT3047C_FinalProject.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20230410144821_ChloeInitial")]
    partial class ChloeInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IT3047C_FinalProject.Models.Chloe", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HobbyId"), 1L, 1);

                    b.Property<string>("HobbyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobdyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyId");

                    b.ToTable("Chloe");
                });
#pragma warning restore 612, 618
        }
    }
}
