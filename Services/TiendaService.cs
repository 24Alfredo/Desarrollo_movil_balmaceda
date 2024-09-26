using MiAppCrud.Models;

namespace MiAppCrud.Services
{
    public class TiendaService
    {
        private readonly Database _database;

        public TiendaService(string dbPath)
        {
            _database = new Database(dbPath);
        }

        public Task<List<Tienda>> GetAll() => _database.GetAllTiendasAsync();

        public Task Add(Tienda tienda) => _database.SaveTiendaAsync(tienda);

        public Task Update(Tienda tienda) => _database.SaveTiendaAsync(tienda);

        public Task Delete(int id) => _database.DeleteTiendaAsync(id);
    }
}
