using MiAppCrud.Models;
using MiAppCrud.Services;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiAppCrud.Controllers
{
    public class CompraController
    {
        private readonly CompraService _compraService;

        public CompraController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "productos.db3");
            _compraService = new CompraService(dbPath);
        }

        public Task<List<Compra>> GetAllCompras() => _compraService.GetAll();
        public Task AddCompra(Compra compra) => _compraService.Add(compra);
        public Task UpdateCompra(Compra compra) => _compraService.Update(compra);
        public Task DeleteCompra(int id) => _compraService.Delete(id);
    }
}
