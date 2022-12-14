using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : GenericController<Planta, PlantaRepository>
    {
        public PlantaController() : base(new PlantaRepository())
        {
        }
    }
}
