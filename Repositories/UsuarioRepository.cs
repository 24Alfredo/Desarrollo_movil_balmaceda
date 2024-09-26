using MiAppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAppCrud.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SQLiteConnection _connection;

        public UsuarioRepository(SQLiteConnection connection)
        {
            _connection = connection;
            _connection.CreateTable<Usuario>();
        }

        public Task<Usuario> GetUsuarioAsync(string nombreUsuario)
        {
            return Task.FromResult(_connection.Table<Usuario>().FirstOrDefault(u => u.NombreUsuario == nombreUsuario));
        }

        public Task<int> AddUsuarioAsync(Usuario usuario)
        {
            return Task.FromResult(_connection.Insert(usuario));
        }
    }
}
