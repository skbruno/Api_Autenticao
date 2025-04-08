using Api_Autentication.DTOs;
using Api_Autentication.Models;

namespace Api_Autentication.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponseDTO> CriarUsuarioAsync(UsuarioDTO dto);
        Task<UsuarioResponseDTO> AutenticarUsuarioAsync(loginDTO usuario);
        Task<Usuario> LogoutUsuarioAsync(int id);
        Task<List<Usuario>> ObterTodosUsuarioAsync();
        Task<Usuario> ObterUsuarioAsync(string email);
        Task<bool> AlterarUsuarioAsync(AlteracaoDTO usuario, int id);
        Task<bool> ExcluirUsuarioAsync(int id);
    }
}
