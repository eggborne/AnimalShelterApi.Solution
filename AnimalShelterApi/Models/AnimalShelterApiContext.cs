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
        new Animal { AnimalId = 2, Species = "cat", Breed = "Short Hair", Gender = "Female", Name = "Curtesia"}
      );
    }
  }
}