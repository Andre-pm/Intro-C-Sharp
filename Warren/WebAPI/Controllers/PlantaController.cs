using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : ControllerBase
    {
        private PlantaRepository repo;
        public PlantaController()
        {
            this.repo = new PlantaRepository();
        }

        [HttpGet]
        public List<Planta> Get()
        {
            return repo.GetAll();
        }

        [HttpGet("{id}")]
        public Planta GetByID(int id)
        {
            return repo.GetById(id);
        }

        [HttpPost]
        public string Post(Planta model)
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
