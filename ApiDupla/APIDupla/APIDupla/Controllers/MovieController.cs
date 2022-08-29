using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : ControllerBase
    {
        private MovieRepository repo;

        public MovieController()
        {
            this.repo = new MovieRepository();
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return repo.GetAll();
        }
        
        [HttpGet("id")]
        public Movie GetById(int id)
        {
            return repo.GetById(id);
        }

        [HttpPost]
        public string Post(Movie entity)
        {
            return repo.Create(entity);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return repo.Delete(id);
        }
    }
}
