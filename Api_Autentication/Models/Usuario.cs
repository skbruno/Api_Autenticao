using Microsoft.AspNetCore.Identity;

namespace Api_Autentication.Models
{
    public class Usuario
    {
        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }

        public Usuario(int usuarioId, string nome, string email)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Email = email;
        }

        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void AlterarSenha(byte[] passwordHash, byte[] passwordSalt)
        {
            PasswordHash = passwordHash;
            PasswordHash = passwordSalt;
        }
    }
}
