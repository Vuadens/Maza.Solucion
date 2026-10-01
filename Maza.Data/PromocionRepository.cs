using Microsoft.EntityFrameworkCore;
using Maza.DomainModel;
using Maza.DTOs;

namespace Maza.Data
{
    public class PromocionRepository : IPromocionRepository
    {
        private static PromocionesContext CreateContext()
        {
            return new PromocionesContext();
        }
        // instaciamos el dbContext

        public async Task<List<Promocion>> PromosXestadoAsync(string estado)
        {
            var _context = CreateContext();
            return await _context.Promociones.Where(p => p.Estado == estado).ToListAsync();
        }
        public async Task<Promocion> CrearPromoConDTOAsync(PromoDTO promoDTO)
        {
            var _context = CreateContext();
            var nuevaPromo = new Promocion {
                Nombre = promoDTO.Nombre,
                Descuento = promoDTO.Descuento,
                FechaInicio = promoDTO.FechaInicio,
                FechaFin = promoDTO.FechaFin,
                Estado = "Activa"   
            };
            await _context.AddAsync(nuevaPromo);
            await _context.SaveChangesAsync();
            return nuevaPromo;
        }
        public async Task<bool> ExpirarPromoAsync(int promocionId)
        {
            var _context = CreateContext();
            var promocionAexpirar = await _context.Promociones.FindAsync(promocionId);
            if (promocionAexpirar != null)
            {
                promocionAexpirar.Estado = "Expirada";
                _context.Promociones.Update(promocionAexpirar); //la línea _context.Promociones.Update(promocionAexpirar) es innecesaria (no incorrecta)
                await _context.SaveChangesAsync();
                return true;
            }
            
            return false;
        }
    }           /*: como promocionAexpirar salió de FindAsync sobre el mismo _context, EF Core ya lo está "rastreando" 
                con solo cambiar promocionAexpirar.Estado = "Expirada" y llamar SaveChangesAsync() alcanza.*/
}

