using System.ComponentModel.Design;
using CleanArchitecture.Application.Common.Intefaces.Authentication;
using CleanArchitecture.Application.Common.Intefaces.Services;
using CleanArchitecture.Infrastructure.Authentication;
using CleanArchitecture.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;




namespace CleanArchitecture.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Add here
        // JWT Configuration
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.JwtSettingsSection)); 

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}
