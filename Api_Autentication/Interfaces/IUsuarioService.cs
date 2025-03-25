using Api_Autentication.DTOs;
using Api_Autentication.Models;

namespace Api_Autentication.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponseDTO> CriarUsuariosAsync(Usuario usuario);
        Task<UsuarioResponseDTO> AutenticarUsuarioAsync(Usuario usuario);
        Task<UsuarioResponseDTO> AlterarAsync(Usuario usuario);
        Task<UsuarioResponseDTO> ExcluirAsync(int id);
        Task<IEnumerable<UsuarioResponseDTO>> SelecionarTodosAsync(Usuario usuario);
    }
}
