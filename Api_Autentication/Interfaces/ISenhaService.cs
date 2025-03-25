using Api_Autentication.DTOs;
using Api_Autentication.Models;

namespace Api_Autentication.Interfaces
{
    public interface ISenhaService
    {
        Task<SenhaDTO> GerarHash(string senha);
        Task<bool> ValidarSenha(string senha, string hashArmazenado);
    }
}
