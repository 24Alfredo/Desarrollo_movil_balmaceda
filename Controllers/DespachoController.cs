using MiAppCrud.Models;
using MiAppCrud.Services;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiAppCrud.Controllers
{
    public class DespachoController
    {
        private readonly DespachoService _despachoService;

        public DespachoController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "miappcrud.db");
            _despachoService = new DespachoService(dbPath);
        }

        public Task<List<Despacho>> GetAllDespachos() => _despachoService.GetAll();

        public Task<Despacho> GetDespachoById(int id) => _despachoService.GetById(id);

        public Task AddDespacho(Despacho despacho) => _despachoService.Add(despacho);

        public Task UpdateDespacho(Despacho despacho) => _despachoService.Update(despacho);

        public Task DeleteDespacho(int id) => _despachoService.Delete(id);
    }
}
