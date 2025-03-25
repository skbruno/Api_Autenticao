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
        private readonly ISenhaService _senhaService;

        public UsuarioController(IUsuarioService usuarioService, ISenhaService senhaService)
        {
            _usuarioService = usuarioService;
            _senhaService = senhaService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario(UsuarioDTO dto)
        {
            var senhaDto = await _senhaService.GerarHash(dto.Password);

            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                PasswordHash = senhaDto.SenhaHash,
                PasswordSalt = senhaDto.SenhaSalt
            };

            var usuarioCriado = await _usuarioService.CriarUsuariosAsync(usuario);

            var response = new UsuarioResponseDTO
            {
                UsuarioId = usuarioCriado.UsuarioId,
                Nome = usuarioCriado.Nome,
                Email = usuarioCriado.Email
            };

            return Ok(response);
        }

    }
}
