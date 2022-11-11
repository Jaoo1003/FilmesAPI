using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Services;

namespace UsuariosAPI.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase{

        private LogoutService _logoutService;

        public LogoutController(LogoutService logoutService) {
            _logoutService = logoutService;
        }

        [HttpPost]
        public IActionResult DeslogaUsusario() {
            Result resultado = _logoutService.DeslogaUsusario();
            if (resultado.IsFailed) return Unauthorized(resultado.Errors);
            return Ok(resultado.Successes);
        }
    }
}
