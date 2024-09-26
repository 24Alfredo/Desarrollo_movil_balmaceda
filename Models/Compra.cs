using SQLite;

namespace MiAppCrud.Models
{
    public class Compra
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string TipoEntrega { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal PrecioTotal { get; set; }
        public int TiendaId { get; set; }
        public int DespachoId { get; set; }
        public int DetallePagoId { get; set; }
    }
}
