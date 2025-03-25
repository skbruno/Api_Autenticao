using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Autentication.Models
{
    public class Usuario
    {
        public int UsuarioId { get;  set; }
        public string? Nome { get;  set; }
        public string? Email { get;  set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public Usuario ()
        {

        }

        public Usuario(int usuarioId, string nome, string email)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Email = email;
        }

        public Usuario(string nome, string email, string passwordHash, string passwordSalt)
        {
            Nome = nome;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;


        }
    }
}
