using Maza.DomainModel;
using Maza.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maza.Application.Services
{
    public interface IPromocionService //firma del service
    {
        Task<Promocion> CrearPromoConDTO(PromoDTO promoDTO); //solo devolvemos una promo, la ui maneja la "logica" 
                                                             //de mostrar la lista completa de promos actualizada con esta nueva
        Task<List<Promocion>> PromosXestadoAsync(string estado);
        Task<List<Promocion>> ExpirarPromoAsync(int promocionId);
    }
}
