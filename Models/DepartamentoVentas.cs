using SQLite;

namespace MiAppCrud.Models
{
    public class DepartamentoVentas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
