using Api_Autentication.DTOs;
using System.Security.Cryptography;
using Api_Autentication.Interfaces;

namespace Api_Autentication.Services
{
    public class SenhaService : ISenhaService
    {
        private const int TamanhoSalt = 16;  
        private const int Iteracoes = 100000; 
        private const int TamanhoHash = 32;

        public async Task<SenhaDTO> GerarHash(string senha)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(TamanhoSalt);

            using var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, Iteracoes, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(TamanhoHash);

            byte[] hashComSalt = new byte[TamanhoSalt + hash.Length];
            Array.Copy(salt, 0, hashComSalt, 0, TamanhoSalt);
            Array.Copy(hash, 0, hashComSalt, TamanhoSalt, hash.Length);

            return new SenhaDTO
            {
                SenhaHash = Convert.ToBase64String(hashComSalt),
                SenhaSalt = Convert.ToBase64String(salt)
            };
        }

        public async Task<bool> ValidarSenha(string senha, string hashArmazenado)
        {
            byte[] hashBytes = Convert.FromBase64String(hashArmazenado);

            byte[] salt = new byte[TamanhoSalt];
            Array.Copy(hashBytes, 0, salt, 0, TamanhoSalt);

            using var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, Iteracoes, HashAlgorithmName.SHA256);
            byte[] hashGerado = pbkdf2.GetBytes(TamanhoHash);

            for (int i = 0; i < TamanhoHash; i++)
            {
                if (hashBytes[TamanhoSalt + i] != hashGerado[i])
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
