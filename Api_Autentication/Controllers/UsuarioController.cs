using Api_Autentication.DTOs;
using Api_Autentication.Interfaces;
using Api_Autentication.Models;
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

        [HttpPost("criar_usuario")]
        public async Task<IActionResult> CriarUsuario(UsuarioDTO dto)
        {
            var usuarioCriado = await _usuarioService.CriarUsuariosAsync(dto);
            return Ok(usuarioCriado);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(loginDTO dto)
        {
            var Login = await _usuarioService.AutenticarUsuarioAsync(dto);
            return Ok(Login);
        }

    }
}
