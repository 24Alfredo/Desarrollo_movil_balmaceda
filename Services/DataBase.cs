using SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using MiAppCrud.Models;

namespace MiAppCrud.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            // Inicializar las tablas
            _database.CreateTableAsync<Producto>().Wait();
            _database.CreateTableAsync<Categoria>().Wait();
            _database.CreateTableAsync<Tienda>().Wait();
            _database.CreateTableAsync<Despacho>().Wait();
            _database.CreateTableAsync<Compra>().Wait();
            _database.CreateTableAsync<DepartamentoVentas>().Wait(); 
         
            _database.CreateTableAsync<Usuario>().Wait();
          
        }

        // Métodos para productos
        public Task<List<Producto>> GetAllProductosAsync() => _database.Table<Producto>().ToListAsync();
        public Task<Producto> GetProductoAsync(int id) => _database.Table<Producto>().FirstOrDefaultAsync(p => p.Id == id);
        public Task<int> SaveProductoAsync(Producto producto) => producto.Id != 0 ? _database.UpdateAsync(producto) : _database.InsertAsync(producto);
        public Task<int> DeleteProductoAsync(int id) => _database.DeleteAsync<Producto>(id);

        // Métodos para categorías
        public Task<List<Categoria>> GetAllCategoriasAsync() => _database.Table<Categoria>().ToListAsync();
        public Task<Categoria> GetCategoriaAsync(int id) => _database.Table<Categoria>().FirstOrDefaultAsync(c => c.Id == id);
        public Task<int> SaveCategoriaAsync(Categoria categoria) => categoria.Id != 0 ? _database.UpdateAsync(categoria) : _database.InsertAsync(categoria);
        public Task<int> DeleteCategoriaAsync(int id) => _database.DeleteAsync<Categoria>(id);

        // Métodos para tiendas
        public Task<List<Tienda>> GetAllTiendasAsync() => _database.Table<Tienda>().ToListAsync();
        public Task<Tienda> GetTiendaAsync(int id) => _database.Table<Tienda>().FirstOrDefaultAsync(t => t.Id == id);
        public Task<int> SaveTiendaAsync(Tienda tienda) => tienda.Id != 0 ? _database.UpdateAsync(tienda) : _database.InsertAsync(tienda);
        public Task<int> DeleteTiendaAsync(int id) => _database.DeleteAsync<Tienda>(id);

        // Métodos para compras
        public Task<List<Compra>> GetAllComprasAsync() => _database.Table<Compra>().ToListAsync();
        public Task<Compra> GetCompraAsync(int id) => _database.Table<Compra>().FirstOrDefaultAsync(c => c.Id == id);
        public Task<int> SaveCompraAsync(Compra compra) => compra.Id != 0 ? _database.UpdateAsync(compra) : _database.InsertAsync(compra);
        public Task<int> DeleteCompraAsync(int id) => _database.DeleteAsync<Compra>(id);

        // Métodos para departamento de ventas
        public Task<List<DepartamentoVentas>> GetAllDepartamentosVentasAsync() => _database.Table<DepartamentoVentas>().ToListAsync();
        public Task<DepartamentoVentas> GetDepartamentoVentasAsync(int id) => _database.Table<DepartamentoVentas>().FirstOrDefaultAsync(d => d.Id == id);
        public Task<int> SaveDepartamentoVentasAsync(DepartamentoVentas departamentoVentas) => departamentoVentas.Id != 0 ? _database.UpdateAsync(departamentoVentas) : _database.InsertAsync(departamentoVentas);
        public Task<int> DeleteDepartamentoVentasAsync(int id) => _database.DeleteAsync<DepartamentoVentas>(id);

        // Métodos para despachos
        public Task<List<Despacho>> GetAllDespachosAsync() => _database.Table<Despacho>().ToListAsync();
        public Task<Despacho> GetDespachoAsync(int id) => _database.Table<Despacho>().FirstOrDefaultAsync(d => d.Id == id);
        public Task<int> SaveDespachoAsync(Despacho despacho) => despacho.Id != 0 ? _database.UpdateAsync(despacho) : _database.InsertAsync(despacho);
        public Task<int> DeleteDespachoAsync(int id) => _database.DeleteAsync<Despacho>(id);

        // Métodos para usuarios
        public Task<List<Usuario>> GetAllUsuariosAsync() => _database.Table<Usuario>().ToListAsync();
        public Task<Usuario> GetUsuarioAsync(int id) => _database.Table<Usuario>().FirstOrDefaultAsync(u => u.Id == id);
        public Task<int> SaveUsuarioAsync(Usuario usuario) => usuario.Id != 0 ? _database.UpdateAsync(usuario) : _database.InsertAsync(usuario);
        public Task<int> DeleteUsuarioAsync(int id) => _database.DeleteAsync<Usuario>(id);
     

        internal SQLiteAsyncConnection GetDatabaseConnection()
        {
            throw new NotImplementedException();
        }
    }
}

