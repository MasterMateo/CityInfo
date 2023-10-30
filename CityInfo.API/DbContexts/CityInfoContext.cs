using CityInfo.API.Entities;
using CityInfo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;


        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("NYC")
                {
                    Id = 1,
                    Description = "The one with big park."
                },
                new City("Antwerp")
                {
                    Id = 2,
                    Description = "The one with the cathedral."
                },
                new City("Paris")
                {
                    Id = 3,
                    Description = "The one where niggas at."
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("Central Park")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "The most visited park in US."
                },
                new PointOfInterest("Empire State Building")
                {
                    Id= 2,
                    CityId = 1,
                    Description = "A 102-story skyscraper."
                },
                new PointOfInterest("Cathedral")
                {
                    Id= 3,
                    CityId = 2,
                    Description = "A Gothic style cathedral"
                },
                new PointOfInterest("Antwerp Central Station")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "The finest example of railway architecture."
                },
                new PointOfInterest("Effel Tower")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "Big ass tower from the photoes."
                },
                new PointOfInterest("The Louvre")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "The world's largest museum."
                }
                );
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
