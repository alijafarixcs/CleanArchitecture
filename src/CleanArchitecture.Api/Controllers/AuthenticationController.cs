using CleanArchitecture.Contracts.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    //[Route("api/[controller]")]
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("register")]

        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            return Ok();
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            return Ok();
        }
    }
}
