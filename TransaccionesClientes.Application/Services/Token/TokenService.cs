using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TransaccionesClientes.Application.DTOs.Clientes;
using TransaccionesClientes.Application.Interfaces.Services.Token;

namespace TransaccionesClientes.Application.Services.Token
{
    public class TokenService : ITokenService
    {
        private readonly string _token = "TransaccionesClientes2026*ClaveSecreta!";

        public string GetToken(ClientesResponseDto responseDto)
        {
            var claims = new[]
            {
                new Claim("IdCliente", responseDto.IdCliente.ToString()),
                new Claim(ClaimTypes.Email, responseDto.Email ?? "")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_token));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "TransaccionesClientes",
                audience: "TransaccionesClientes",
                claims: claims,
                expires: DateTime.UtcNow,
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
