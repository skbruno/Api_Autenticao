using Api_Autentication.DTOs;
using Api_Autentication.Models;

namespace Api_Autentication.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponseDTO> CriarUsuariosAsync(UsuarioDTO dto);
        Task<UsuarioResponseDTO> AutenticarUsuarioAsync(loginDTO usuario);
        Task<UsuarioResponseDTO> AlterarAsync(Usuario usuario);
        Task<UsuarioResponseDTO> ExcluirAsync(int id);
        Task<IEnumerable<UsuarioResponseDTO>> SelecionarTodosAsync(Usuario usuario);
    }
}
