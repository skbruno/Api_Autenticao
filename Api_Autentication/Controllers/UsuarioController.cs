using Api_Autentication.DTOs;
using Api_Autentication.Interfaces;
using Api_Autentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api_Autentication.Controllers
{
    [Route("[controller]")]
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
            var usuarioCriado = await _usuarioService.CriarUsuariosAsync(dto);
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
            var Login = await _usuarioService.AutenticarUsuarioAsync(dto);
            return Ok(Login);
        }

        [Authorize]
        [HttpGet("/api/users")]
        public async Task<IActionResult> SelecionarTodosAsync(loginDTO dto)
        {
            var Login = await _usuarioService.AutenticarUsuarioAsync(dto);
            return Ok(Login);
        }

        [Authorize]
        [HttpGet("/api/users/{id}")]
        public async Task<IActionResult> SelecionarUser(loginDTO dto)
        {
            var Login = await _usuarioService.AutenticarUsuarioAsync(dto);
            return Ok(Login);
        }

        [Authorize]
        [HttpPut("/api/users/{id}")]
        public async Task<IActionResult> AlterarAsync(loginDTO dto)
        {
            var Login = await _usuarioService.AutenticarUsuarioAsync(dto);
            return Ok(Login);
        }

        [Authorize]
        [HttpDelete("/api/users/{id}")]
        public async Task<IActionResult> ExcluirAsync(loginDTO dto)
        {
            var Login = await _usuarioService.AutenticarUsuarioAsync(dto);
            return Ok(Login);
        }

    }
}
