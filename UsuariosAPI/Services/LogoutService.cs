using FluentResults;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Modelos;

namespace UsuariosAPI.Services {
    public class LogoutService {
        private SignInManager<CustomIdentityUser> _signInManager;

        public LogoutService(SignInManager<CustomIdentityUser> signInManager) {
            _signInManager = signInManager;
        }

        public Result DeslogaUsusario() {
            var resultadoIdentity = _signInManager.SignOutAsync();
            if (resultadoIdentity.IsCompletedSuccessfully) return Result.Ok();
            return Result.Fail("Logout falhou");
        }
    }
}
