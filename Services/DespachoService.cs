using MiAppCrud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiAppCrud.Services
{
    public class DespachoService
    {
        private readonly Database _database;

        public DespachoService(string dbPath)
        {
            _database = new Database(dbPath);
        }

        public Task<List<Despacho>> GetAll() => _database.GetAllDespachosAsync();

        public Task<Despacho> GetById(int id) => _database.GetDespachoAsync(id);

        public Task Add(Despacho despacho) => _database.SaveDespachoAsync(despacho);

        public Task Update(Despacho despacho) => _database.SaveDespachoAsync(despacho);

        public Task Delete(int id) => _database.DeleteDespachoAsync(id);
    }
}
