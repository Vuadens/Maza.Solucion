using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Maza.DomainModel
{
    public class Promocion
    {
        public int PromocionId { get; set; } 
        public required string Nombre { get; set; } 
        public required DateOnly FechaInicio { get; set; } 
        public required DateOnly FechaFin { get; set; } 
        public required decimal Descuento { get; set; } 
        public required string Estado { get; set; }
    };
}
