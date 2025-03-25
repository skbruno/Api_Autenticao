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

        [HttpPost]
        public async Task<IActionResult> CriarUsuario(UsuarioDTO dto)
        {
            var novoUsuario = await _usuarioService.CriarUsuariosAsync(dto);
            return Ok(novoUsuario);
        }

    }
}
