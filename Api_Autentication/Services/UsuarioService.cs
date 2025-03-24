using Api_Autentication.DTOs;
using Api_Autentication.Interfaces;
using Api_Autentication.Context;

namespace Api_Autentication.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public Task<UsuarioDTO> Alterar(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> Incluir(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> SelecionarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioDTO>> SelecionarTodosAsync(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }
    }
}
