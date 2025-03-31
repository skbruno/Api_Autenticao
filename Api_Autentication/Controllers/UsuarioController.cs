using Api_Autentication.DTOs;
using Api_Autentication.Interfaces;
using Api_Autentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Api_Autentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("/api/auth/register")]
        public async Task<IActionResult> CriarUsuario(UsuarioDTO dto)
        {
            var usuarioCriado = await _usuarioService.CriarUsuarioAsync(dto);
            return Ok(usuarioCriado);
        }

        [HttpPost("/api/auth/login")]
        public async Task<IActionResult> Login(loginDTO dto)
        {
            var Login = await _usuarioService.AutenticarUsuarioAsync(dto);
            return Ok(Login);
        }

        [Authorize]
        [HttpPost("/api/auth/logout")]
        public async Task<IActionResult> Logout(loginDTO dto)
        {
            var Login = await _usuarioService.LogoutUsuarioAsync(dto);
            return Ok(Login);
        }

        [Authorize]
        [HttpGet("/api/users")]
        public async Task<IActionResult> SelecionarTodosAsync()
        {
            var listar = await _usuarioService.ObterTodosUsuarioAsync();
            return Ok(listar);
        }

        [Authorize]
        [HttpGet("/api/users/{email}")]
        public async Task<IActionResult> SelecionarUsuario(string email)
        {
            var listarUsuario = await _usuarioService.ObterUsuarioAsync(email);
            return Ok(listarUsuario);
        }

        [Authorize]
        [HttpPatch("/api/users/me")]
        public async Task<IActionResult> AlterarAsync([FromBody] AlteracaoDTO dto)
        {
            var tokenUsuario = User.FindFirst("UsuarioId")?.Value;

            if (tokenUsuario == null)
            {
                return Unauthorized(new { message = "Usuario nao autenticado" });
            }

            int usuarioId = int.Parse(tokenUsuario);
            var sucesso = await _usuarioService.AlterarUsuarioAsync(dto, usuarioId);

            if (sucesso)
            {
                return Ok(new { message = "Usuario alterado com sucesso" });
            }
            else
            {
                return BadRequest(new { message = "Erro ao atualizar usuario" });
            }
        }

        [Authorize]
        [HttpDelete("/api/users/me")]
        public async Task<IActionResult> ExcluirAsync()
        {
            var tokenUsuario = User.FindFirst("UsuarioId")?.Value;

            if (tokenUsuario == null)
            {
                return Unauthorized(new { message = "Usuario nao autenticado" });
            }

            int usuarioId = int.Parse(tokenUsuario);
            bool sucesso = await _usuarioService.ExcluirUsuarioAsync(usuarioId);

            if (sucesso)
            {
                return Ok(new { message = "Usuario deletado com sucesso" });
            }
            else
            {
                return BadRequest(new { message = "Erro ao deletar usuario" });
            }
        }

    }
}
