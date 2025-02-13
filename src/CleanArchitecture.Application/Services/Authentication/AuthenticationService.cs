using System;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Intefaces.Authentication;
using CleanArchitecture.Application.Services.Authentication;


public class MockAuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public MockAuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator=jwtTokenGenerator;
    }
    public Task<AuthenticationResult> RegisterAsync(string email, string password, string firstName, string lastName)
    {
        // Check if user already exists

        // Create user (generate unique ID)
        Guid userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        var response= new AuthenticationResult(
            userId,
            token,
            firstName,
            lastName,
            email
            );
        return Task.FromResult(response);
    }

    public Task<AuthenticationResult> LoginAsync(string email, string password)
    {
        var id = Guid.NewGuid();
        var response = new AuthenticationResult(
             id,
            email,
            null,
            null,
            "mock_token");
        return Task.FromResult(response);
    }
}