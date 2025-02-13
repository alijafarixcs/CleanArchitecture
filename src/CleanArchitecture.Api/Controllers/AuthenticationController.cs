using CleanArchitecture.Application.Services.Authentication;
using CleanArchitecture.Contracts.Authentication;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    //[Route("api/[controller]")]
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;


        }
        [HttpPost("register")]

        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
           var result= await _authenticationService.RegisterAsync(registerRequest.Email,
               registerRequest.Password,
                registerRequest.FirstName,
                registerRequest.LastName
                );

            return Ok(result);
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            var result = await _authenticationService.LoginAsync(
            loginRequest.Email,loginRequest.Password);

            return Ok(result);
        }
    }
}
