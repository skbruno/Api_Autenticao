using Microsoft.AspNetCore.Identity;

namespace Api_Autentication.Models
{
    public class Usuario
    {
        public int UsuarioId { get;  set; }
        public string? Nome { get;  set; }
        public string? Email { get;  set; }
        public string? Password { get;  set; }

        public Usuario ()
        {

        }

        public Usuario(int usuarioId, string nome, string email)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Email = email;
        }

        public Usuario(string nome, string email, string password)
        {
            Nome = nome;
            Email = email;
            Password = password;
            
        }
    }
}
