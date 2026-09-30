using Maza.DomainModel;
namespace Maza.Data
{
    public interface IPromocionRepository
    {
        Task<List<Promocion>> PromosXestadoAsync(string estado);
        Task<Promocion> AgregarNuevaPromoAsync(Promocion promocion);
        Task<bool> ExpirarPromoAsync(int promocionId);
    }
}
