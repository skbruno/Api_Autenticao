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
        private readonly ISenhaService _senhaService;

        public UsuarioService(AppDbContext context, ISenhaService senhaService)
        {
            _context = context;
            _senhaService = senhaService;
        }

        public async Task<UsuarioResponseDTO> CriarUsuarioAsync(UsuarioDTO dto)
        {
            var SenhaDto = await _senhaService.GerarHash(dto.Password);

            var user = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                PasswordHash = SenhaDto.SenhaHash,
                PasswordSalt = SenhaDto.SenhaSalt
            };

            await _context.Usuarios.AddAsync(user);
            await _context.SaveChangesAsync();

            return new UsuarioResponseDTO
            {
                UsuarioId = user.UsuarioId,
                Nome = user.Nome,
                Email = user.Email
            };
        }

        public async Task<UsuarioResponseDTO> AutenticarUsuarioAsync(loginDTO user)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == user.Email);

            if (usuario == null)
            {
                throw new Exception("Email ou senha invalido");
            }

            var validacao = await _senhaService.ValidarSenha(user.Password, usuario.PasswordHash);

            if (validacao)
            {
                var token = TokenService.GenerateToken(usuario);
                Console.Write(token);

                return new UsuarioResponseDTO
                {
                    UsuarioId = usuario.UsuarioId,
                    Nome = usuario.Nome,
                    Email = usuario.Email
                };
            }

            throw new Exception("Credenciais inválidas.");
        }

        public Task<UsuarioResponseDTO> LogoutUsuarioAsync(loginDTO user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Usuario>> ObterTodosUsuarioAsync()
        {
            return await _context.Usuarios.AsNoTracking().ToListAsync();
        }

        public async Task<Usuario> ObterUsuarioAsync(string email)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<UsuarioResponseDTO> AlterarUsuarioAsync(UsuarioDTO user)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == user.Email);

            var SenhaDto = await _senhaService.GerarHash(user.Password);

            usuario.Nome = user.Nome;
            usuario.Email = user.Email;
            usuario.PasswordHash = SenhaDto.SenhaHash;
            usuario.PasswordSalt = SenhaDto.SenhaSalt;

            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return new UsuarioResponseDTO
            {
                UsuarioId = usuario.UsuarioId,
                Nome = usuario.Nome,
                Email = usuario.Email
            };
        }

        public async Task<bool> ExcluirUsuarioAsync(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);
            _context.Remove(usuario);

            var estadoObj = _context.Entry(usuario);
            if (estadoObj.State == EntityState.Deleted)
            {
                _context.SaveChangesAsync();
                return true;
            }

            return false;

        }
    }
}


