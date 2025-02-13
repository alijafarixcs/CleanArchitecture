using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services.Authentication
{
  

    public interface IAuthenticationService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password, string firstName, string lastName);
        Task<AuthenticationResult> LoginAsync(string email, string password);
    }
}
