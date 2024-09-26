
using MiAppCrud.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiAppCrud.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetUsuarioAsync(string nombreUsuario);
        Task<int> AddUsuarioAsync(Usuario usuario);
    }

}
