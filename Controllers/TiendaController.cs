using MiAppCrud.Models;
using MiAppCrud.Services;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiAppCrud.Controllers
{
    public class TiendaController
    {
        private readonly TiendaService _tiendaService;

        public TiendaController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "productos.db3");
            _tiendaService = new TiendaService(dbPath);
        }

        public Task<List<Tienda>> GetAllTiendas() => _tiendaService.GetAll();
        public Task AddTienda(Tienda tienda) => _tiendaService.Add(tienda);
        public Task UpdateTienda(Tienda tienda) => _tiendaService.Update(tienda);
        public Task DeleteTienda(int id) => _tiendaService.Delete(id);
    }
}
