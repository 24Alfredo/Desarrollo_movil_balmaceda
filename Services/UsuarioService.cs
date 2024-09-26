using System.Collections.Generic;
using System.Threading.Tasks;
using MiAppCrud.Models; // Asegúrate de que el modelo Usuario esté en este espacio de nombres
using SQLite;

namespace MiAppCrud.Services
{
    public class UsuarioService
    {
        private readonly SQLiteAsyncConnection _database;

        public UsuarioService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait(); // Crear la tabla si no existe
        }

        // Guardar un usuario (insert o update)
        public Task<int> SaveUsuarioAsync(Usuario usuario)
        {
            return usuario.Id != 0 ? _database.UpdateAsync(usuario) : _database.InsertAsync(usuario);
        }

        // Obtener un usuario por email
        public Task<Usuario> GetUsuarioByEmailAsync(string email)
        {
            return _database.Table<Usuario>().FirstOrDefaultAsync(u => u.Email == email);
        }

        // Obtener todos los usuarios
        public Task<List<Usuario>> GetAllUsuariosAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }
    }
}
