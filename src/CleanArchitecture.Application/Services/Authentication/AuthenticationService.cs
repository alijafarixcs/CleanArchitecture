using System;
using System.Threading.Tasks;
using CleanArchitecture.Application.Services.Authentication;


public class MockAuthenticationService : IAuthenticationService
{
    public Task<AuthenticationResult> RegisterAsync(string email, string password, string firstName, string lastName)
    {
        var id = Guid.NewGuid();
        var response = new AuthenticationResult(
            Id: id,
            FirstName: firstName,
            LastName: lastName,
            Email: email,
            Token: "mock_token");
        return Task.FromResult(response);
    }

    public Task<AuthenticationResult> LoginAsync(string email, string password)
    {
        var id = Guid.NewGuid();
        var response = new AuthenticationResult(
            Id: id,
            Email: email,null,null,
            Token: "mock_token");
        return Task.FromResult(response);
    }
}