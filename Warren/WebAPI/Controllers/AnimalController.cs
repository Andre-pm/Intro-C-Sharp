using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public Animal Get()
        {
            Animal animal = new Animal { Id = 1, Especie = "Cachorro Caramelo", Nome = "Alfredo", Peso = 4.5f };
            return animal;

        }

        [HttpPost]
        public string Post(Animal model)
        {
            AnimalRepository repo = new AnimalRepository();
            return repo.Create(model);
        }
    }
}

