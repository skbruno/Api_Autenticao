using Api_Autentication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api_Autentication.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }


    }
}
