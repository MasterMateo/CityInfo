using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        //public static CitiesDataStore Current { get; } = new CitiesDataStore(); 

        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id= 1,
                    Name = "New York City",
                    Description = "The one with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited park in the USA"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Manhattan"
                        }
                    }
                },
                new CityDto()
                {
                    Id= 2,
                    Name = "Antwerp",
                    Description ="The one with the cathedral that was never really finished",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "A Gothic style cathedral"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Central Station",
                            Description = "The finest example of railway architecture"
                        }
                    }
                },
                new CityDto()
                {
                    Id= 3,
                    Name = "Paris",
                    Description = "The one with niggas in it",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Effel Tower",
                            Description = "Big ass tower from the photoes"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "The world's largest museum"
                        }
                    }
                }
            };
        }
    }
}
