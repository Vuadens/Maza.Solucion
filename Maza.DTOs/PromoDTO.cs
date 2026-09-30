namespace Maza.DTOs
{
    public class PromoDTO
    {
        public required string Nombre { get; set; }
        public required DateOnly FechaInicio { get; set; }
        public required DateOnly FechaFin { get; set; }
        public required decimal Descuento { get; set; }
    }
}
