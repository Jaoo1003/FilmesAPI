using Microsoft.AspNetCore.Identity;

namespace UsuariosAPI.Modelos {
    public class CustomIdentityUser : IdentityUser<int>{
        public DateTime DataNascimento { get; set; }
    }
}
