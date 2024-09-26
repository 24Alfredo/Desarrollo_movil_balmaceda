using SQLite;

namespace MiAppCrud.Models
{
    public class Tienda
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NombreTienda { get; set; }
        public string Ubicacion { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Titulo { get; set; }
    }
}
