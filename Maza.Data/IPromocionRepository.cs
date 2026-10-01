using Maza.DomainModel;
using Maza.DTOs;
namespace Maza.Data
{
    public interface IPromocionRepository
    {
        Task<List<Promocion>> PromosXestadoAsync(string estado);
        Task<Promocion> CrearPromoConDTOAsync(PromoDTO promoDTO);
        Task<bool> ExpirarPromoAsync(int promocionId);
    }
}
