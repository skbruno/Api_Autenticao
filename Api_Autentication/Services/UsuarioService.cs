using Api_Autentication.DTOs;
using Api_Autentication.Interfaces;
using Api_Autentication.Context;
using Api_Autentication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Api_Autentication.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UsuarioResponseDTO> CriarUsuariosAsync(UsuarioDTO dto)
        {
            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Password = dto.Password
            };

            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();

            return new UsuarioResponseDTO
            {
                UsuarioId = usuario.UsuarioId,
                Nome = usuario.Nome,
                Email = usuario.Email
            };
        }

        public async Task<UsuarioResponseDTO> AutenticarUsuarioAsync(UsuarioDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioResponseDTO> AlterarAsync(UsuarioDTO dto)
        {
            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Password = dto.Password
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

        public async Task<IEnumerable<UsuarioResponseDTO>> SelecionarTodosAsync(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }
    }
}


