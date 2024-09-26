using MiAppCrud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiAppCrud.Services
{
    public class CompraService
    {
        private readonly Database _database;

        public CompraService(string dbPath)
        {
            _database = new Database(dbPath);
        }

        public Task<List<Compra>> GetAll() => _database.GetAllComprasAsync();
        public Task Add(Compra compra) => _database.SaveCompraAsync(compra);
        public Task Update(Compra compra) => _database.SaveCompraAsync(compra);
        public Task Delete(int id) => _database.DeleteCompraAsync(id);
    }
}
