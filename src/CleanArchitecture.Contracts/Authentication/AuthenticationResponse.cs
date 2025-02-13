using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Contracts.Authentication
{
    public record AuthenticationResponse
    {
        public Guid Id { get; init; }
        public string? Token { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? Email { get; init; }
        public AuthenticationResponse(Guid id, string? token, string? firstName, string? lastName, string? email)
        {
            Id = id;
            Token = token;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
