using Data.Context;
using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository repo;
        public AnimalController()
        {
            this.repo = new AnimalRepository();
        }

        [HttpGet]
        public List<Animal> Get()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public string Post(Animal model)
        {
            return repo.Create(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}

