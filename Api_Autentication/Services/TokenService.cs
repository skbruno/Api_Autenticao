using Api_Autentication.DTOs;
using Api_Autentication.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api_Autentication.Services
{
    public class TokenService
    {
        public static string GenerateToken(Usuario usuario)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                      new Claim("usuarioId", usuario.UsuarioId.ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        public static string GerarTokenExpirado(Usuario user)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenConfig = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Email)
                }),

                NotBefore = DateTime.UtcNow.AddDays(-2), 
                Expires = DateTime.UtcNow.AddDays(-1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenConfig.CreateToken(tokenDescriptor);
            return tokenConfig.WriteToken(token);
        }

    }
}
