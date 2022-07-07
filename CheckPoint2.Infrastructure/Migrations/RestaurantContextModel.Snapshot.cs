﻿// <auto-generated />

using Checkpoint2.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CheckPoint2.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    partial class RestaurantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("RestaurantApi.Models.restaurant", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Owner")
                    .IsRequired()
                    .HasMaxLength(75);

                b.Property<string>("Type")
                    .IsRequired();

                b.Property<string>("Name")
                    .IsRequired();

                b.HasKey("Id");

                b.ToTable("Restaurants");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Owner = "Bob Martinez",
                        Type = "Mexican",
                        Name = "Great Tacos"
                    },
                    new
                    {
                        Id = 2,
                        Owner = "Michael Khan",
                        Type = "Thai",
                        Name = "Delicious Thai Meals"
                    },
                    new
                    {
                        Id = 3,
                        Owner = "Raj Biswanathan",
                        Type = "Indian",
                        Title = "South Asian Treats"
                    });
            });
#pragma warning restore 612, 618
        }
    }
}