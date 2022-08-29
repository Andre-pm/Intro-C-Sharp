using Data.Context;
using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : GenericController<Animal>
    {
    }
}

