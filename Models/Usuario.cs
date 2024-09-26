using SQLite;

namespace MiAppCrud.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), NotNull]
        public string NombreUsuario { get; set; }

        [MaxLength(100), NotNull]
        public string Contrasena { get; set; }
        public string Email { get; internal set; }
    }
}


