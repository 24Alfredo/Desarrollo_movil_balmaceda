using MiAppCrud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiAppCrud.Services
{
    public class DepartamentoVentasService
    {
        private readonly Database _database;

        public DepartamentoVentasService(string dbPath)
        {
            _database = new Database(dbPath);
        }

        public Task<List<DepartamentoVentas>> GetAll() => _database.GetAllDepartamentosVentasAsync();

        public Task Add(DepartamentoVentas departamentoVentas) => _database.SaveDepartamentoVentasAsync(departamentoVentas);

        public Task Update(DepartamentoVentas departamentoVentas) => _database.SaveDepartamentoVentasAsync(departamentoVentas);

        public Task Delete(int id) => _database.DeleteDepartamentoVentasAsync(id);
    }
}
