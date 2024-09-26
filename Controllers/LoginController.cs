using System.Threading.Tasks;
using MiAppCrud.Models; // Asegúrate de que el modelo Usuario esté en este espacio de nombres
using MiAppCrud.Services;

namespace MiAppCrud.Controllers
{
    public class LoginController
    {
        private readonly UsuarioService _usuarioService;

        public LoginController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // Método para registrar un nuevo usuario
        public async Task<bool> RegistrarUsuarioAsync(string nombreUsuario, string email, string contrasena)
        {
            var usuarioExistente = await _usuarioService.GetUsuarioByEmailAsync(email);
            if (usuarioExistente != null)
            {
                return false; // El usuario ya existe
            }

            var nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Email = email,
                Contrasena = contrasena // En una implementación real, deberías hashear la contraseña
            };

            await _usuarioService.SaveUsuarioAsync(nuevoUsuario);
            return true; // Registro exitoso
        }

        // Método para autenticar un usuario
        public async Task<bool> AutenticarUsuarioAsync(string email, string contrasena)
        {
            // Obtener el usuario por email
            var usuario = await _usuarioService.GetUsuarioByEmailAsync(email);
            if (usuario == null)
            {
                return false; // El usuario no existe
            }

            // Comprobar si la contraseña es correcta (en una implementación real, deberías comparar el hash de la contraseña)
            return usuario.Contrasena == contrasena; // Cambiar esta línea para comparación de hash en producción
        }
    }
}
