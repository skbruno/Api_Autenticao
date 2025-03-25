using Api_Autentication.DTOs;
using Api_Autentication.Models;

namespace Api_Autentication.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponseDTO> CriarUsuariosAsync(UsuarioDTO usuario);
        Task<UsuarioResponseDTO> AutenticarUsuarioAsync(UsuarioDTO usuario);
        Task<UsuarioResponseDTO> AlterarAsync(UsuarioDTO usuario);
        Task<UsuarioResponseDTO> ExcluirAsync(int id);
        Task<IEnumerable<UsuarioResponseDTO>> SelecionarTodosAsync(UsuarioDTO usuario);
    }
}
