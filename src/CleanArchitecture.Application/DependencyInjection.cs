using System.ComponentModel.Design;
using CleanArchitecture.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Add here
        services.AddScoped<IAuthenticationService, MockAuthenticationService>();
      //  services.AddSingleton<IAuthenticationService, MockAuthenticationService>();

        return services;
    }
}
