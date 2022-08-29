using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repo;
        public GenericController(R repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<T> Get()
        {
            return repo.GetAll();
        }

        [HttpGet("{id}")]
        public T GetByID(int id)
        {
            return repo.GetById(id);
        }

        [HttpPost]
        public string Post(T model)
        {
            return repo.Create(model);
        }

        [HttpPut]
        public string Put(T model)
        {
            return repo.Update(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
