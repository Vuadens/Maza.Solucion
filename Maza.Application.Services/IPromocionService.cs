using Maza.DomainModel;
using Maza.DTOs;

namespace Maza.Application.Services
{
    public interface IPromocionService //firma del service
    {
        Task<Promocion> CrearPromoConDTOAsync(PromoDTO promoDTO); //solo devolvemos una promo, la ui maneja la "logica" 
                                                             //de mostrar la lista completa de promos actualizada con esta nueva
        Task<List<Promocion>> PromosXestadoAsync(string estado);
        Task<bool> ExpirarPromoAsync(int promocionId);
    }
}
