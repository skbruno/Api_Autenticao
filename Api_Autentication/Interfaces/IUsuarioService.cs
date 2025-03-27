using Api_Autentication.DTOs;
using Api_Autentication.Models;

namespace Api_Autentication.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponseDTO> CriarUsuariosAsync(UsuarioDTO dto);
        Task<UsuarioResponseDTO> AutenticarUsuarioAsync(loginDTO usuario);
        Task<List<Usuario>> ObterTodosAsync();
        Task<Usuario> ObterUsuarioAsync(string email);
        Task<UsuarioResponseDTO> AlterarAsync(Usuario usuario);
        Task<UsuarioResponseDTO> ExcluirAsync(int id);
    }
}
