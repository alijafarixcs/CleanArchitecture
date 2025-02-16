using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DinnersController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListDinners()
        {
            return NotFound( Array.Empty<string>());
        }
    }
}
