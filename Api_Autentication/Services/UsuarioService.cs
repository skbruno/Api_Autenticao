using Api_Autentication.DTOs;
using Api_Autentication.Interfaces;
using Api_Autentication.Context;
using Api_Autentication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Api_Autentication.Services;

namespace Api_Autentication.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UsuarioResponseDTO> CriarUsuariosAsync(Usuario user)
        {

            await _context.Usuarios.AddAsync(user);
            await _context.SaveChangesAsync();

            return new UsuarioResponseDTO
            {
                UsuarioId = user.UsuarioId,
                Nome = user.Nome,
                Email = user.Email
            };
        }

        public async Task<UsuarioResponseDTO> AutenticarUsuarioAsync(Usuario user)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioResponseDTO> AlterarAsync(Usuario user)
        {
            var usuario = new Usuario
            {
                Nome = user.Nome,
                Email = user.Email,
            };

            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return new UsuarioResponseDTO
            {
                UsuarioId = usuario.UsuarioId,
                Nome = usuario.Nome,
                Email = usuario.Email
            };

        }

        public async Task<UsuarioResponseDTO> ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UsuarioResponseDTO>> SelecionarTodosAsync(Usuario user)
        {
            throw new NotImplementedException();
        }
    }
}


