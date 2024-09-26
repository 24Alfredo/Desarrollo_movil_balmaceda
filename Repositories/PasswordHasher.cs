using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAppCrud.Repositories
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            // Implementa la lógica para hashear la contraseña
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password)); // Ejemplo simple
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            // Implementa la lógica para verificar la contraseña
            return HashPassword(password) == hashedPassword; // Ejemplo simple
        }
    }
}
