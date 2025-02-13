using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Intefaces.Authentication;
using CleanArchitecture.Application.Common.Intefaces.Services;
using CleanArchitecture.Infrastructure.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CleanArchitecture.Infrastructure.Authentication
{
 
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private JwtSettings _jwtSettings;

        public JwtTokenGenerator(IDateTimeProvider dateTimeProvider,IOptions<JwtSettings> jwtoprions)
        {
            _dateTimeProvider = dateTimeProvider;
            _jwtSettings = jwtoprions.Value;
        }
        public string GenerateToken(Guid userId, string firstName, string lastName)
        {
            // 1. Setup Signing Credentials
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)); // **IMPORTANT: DO NOT HARDCODE IN PRODUCTION!**
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // 2. Create Claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, firstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // Unique identifier for the token
            };

            // 3. Generate Token
            var securityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer, // Replace with your actual issuer
                audience: _jwtSettings.Audience, // Add audience for better security
                expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                claims: claims,
                signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
