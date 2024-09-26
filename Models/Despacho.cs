using SQLite;

namespace MiAppCrud.Models
{
    public class Despacho
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string PersonaContacto { get; set; }
        public string Direccion { get; set; }
        public int DepartamentoId { get; set; }
        public int ProvinciaId { get; set; }
        public int DistritoId { get; set; }
        public string Celular { get; set; }
    }
}
