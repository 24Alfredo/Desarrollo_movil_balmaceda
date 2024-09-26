using MiAppCrud.Models;
using MiAppCrud.Services;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiAppCrud.Controllers
{
    public class DepartamentoVentasController
    {
        private readonly DepartamentoVentasService _departamentoVentasService;

        public DepartamentoVentasController()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "departamentosVentas.db3");
            _departamentoVentasService = new DepartamentoVentasService(dbPath);
        }

        public Task<List<DepartamentoVentas>> GetAllDepartamentosVentas()
        {
            return _departamentoVentasService.GetAll();
        }

        public void AddDepartamentoVentas(DepartamentoVentas departamentoVentas)
        {
            _departamentoVentasService.Add(departamentoVentas);
        }

        public void UpdateDepartamentoVentas(DepartamentoVentas departamentoVentas)
        {
            _departamentoVentasService.Update(departamentoVentas);
        }

        public void DeleteDepartamentoVentas(int id)
        {
            _departamentoVentasService.Delete(id);
        }
    }
}

