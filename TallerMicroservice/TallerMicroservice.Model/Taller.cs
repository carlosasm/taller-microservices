using System;

namespace TallerMicroservice.Model
{
    public class Taller
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public char Tipo { get; set; }
        public string Descripcion { get; set; }
        public int IdCarro { get; set; }
        public int Costo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int CostoCarro { get; set; }
    }
}