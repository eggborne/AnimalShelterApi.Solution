using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> GetAnimals(int id, string species, string breed, string gender, string name, int page = 1, int pageSize = 10)
    {
      IQueryable<Animal> query = _db.Animals.AsQueryable();

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      if (breed != null)
      {  
        query = query.Where(entry => entry.Breed == breed);
      }
      if (gender != null)
      {  
        query = query.Where(entry => entry.Gender == gender);
      }
      if (name != null)
      {  
        query = query.Where(entry => entry.Name == name);
      }
      if (id != 0)
      {  
        query = query.Where(entry => entry.AnimalId  == id);
      }
        // Calculate the number of items to skip based on the page size and requested page.
        int skip = (page - 1) * pageSize;

        // Retrieve the data from your data source, applying the pagination parameters.
        List<Animal> animals = await query
          .Skip(skip)
          .Take(pageSize)
          .ToListAsync();

        // Determine the total number of items in your data source.
        int totalCount = _db.Animals.Count();

        // Create a response object to hold the paginated data and total count.
        var response = new
        {
          Data = animals,
          TotalCount = totalCount,
          Page = page,
          PageSize = pageSize
        };

        // Return the paginated data to the client.
        return Ok(response);
    }

    // GET: api/animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal Animal = await _db.Animals.FindAsync(id);

      if (Animal == null)
      {
        return NotFound();
      }

      return Animal;
    }
    
    // POST api/animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    // PUT: api/Animals/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Animals.Update(animal);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // DELETE: api/Animals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      Animal Animal = await _db.Animals.FindAsync(id);
      if (Animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(Animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}