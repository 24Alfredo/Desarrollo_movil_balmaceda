using SQLite;

namespace MiAppCrud.Models
{
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Relación con Categoría
        public int CategoriaId { get; set; }

        // Relación con Proveedor
        public int ProveedorId { get; set; }
    }

}