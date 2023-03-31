using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>().HasData(
        new Animal { AnimalId = 1, Species = "dog", Breed = "Chihuahua", Gender = "Male", Name = "Conan" },
        new Animal { AnimalId = 2, Species = "cat", Breed = "ShortHair", Gender = "Female", Name = "Curtesia"},
        new Animal { AnimalId = 3, Species = "dog", Breed = "GoldenRetriever", Gender = "Male", Name = "Chauncey"},
        new Animal { AnimalId = 4, Species = "cat", Breed = "ShortHair", Gender = "Male", Name = "Curtis"},
        new Animal { AnimalId = 5, Species = "dog", Breed = "Corgi", Gender = "Female", Name = "Ginger"},
        new Animal { AnimalId = 6, Species = "dog", Breed = "Corgi", Gender = "Male", Name = "Winston"},
        new Animal { AnimalId = 7, Species = "cat", Breed = "Siamese", Gender = "Male", Name = "Sugar"},
        new Animal { AnimalId = 8, Species = "dog", Breed = "Airedale", Gender = "Female", Name = "Valerie"},
        new Animal { AnimalId = 9, Species = "cat", Breed = "LongHair", Gender = "Male", Name = "Mingus"},
        new Animal { AnimalId = 10, Species = "dog", Breed = "Dachshund", Gender = "Male", Name = "Dexter"},
        new Animal { AnimalId = 11, Species = "cat", Breed = "ShortHair", Gender = "Male", Name = "Mingus"},
        new Animal { AnimalId = 12, Species = "dog", Breed = "Boxer", Gender = "Female", Name = "Jasmine"},
        new Animal { AnimalId = 13, Species = "cat", Breed = "Siamese", Gender = "Male", Name = "Linus"},
        new Animal { AnimalId = 14, Species = "dog", Breed = "Beagle", Gender = "Female", Name = "Petunia"},
        new Animal { AnimalId = 15, Species = "dog", Breed = "Bulldog", Gender = "Male", Name = "Tiny"},
        new Animal { AnimalId = 16, Species = "cat", Breed = "ShortHair", Gender = "Female", Name = "Minnie"},
        new Animal { AnimalId = 17, Species = "cat", Breed = "ShortHair", Gender = "Male", Name = "Marvin"},
        new Animal { AnimalId = 18, Species = "dog", Breed = "Pomeranian", Gender = "Male", Name = "Fizzgig"},
        new Animal { AnimalId = 19, Species = "cat", Breed = "LongHair", Gender = "Male", Name = "Wolfie"},
        new Animal { AnimalId = 20, Species = "dog", Breed = "Husky", Gender = "Female", Name = "Pandora"},
        new Animal { AnimalId = 21, Species = "dog", Breed = "ShihTzu", Gender = "Male", Name = "Batman"}
      );
    }
  }
}