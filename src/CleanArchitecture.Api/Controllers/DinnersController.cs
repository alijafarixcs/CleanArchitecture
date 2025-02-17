using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]

    public class DinnersController : ControllerBase
    {
        [HttpGet]

        public IActionResult ListDinners()
        {
            var claims = User.Claims.Select(m=>m.Value).ToList();
            return Ok(claims);
        }
    }
}
