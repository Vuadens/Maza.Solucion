using Microsoft.EntityFrameworkCore;
using Maza.DomainModel;

namespace Maza.Data
{
    public class PromocionRepository : IPromocionRepository
    {
        private PromocionesContext CreateContext()
        {
            return new PromocionesContext();
        }
        // instaciamos el dbContext

        public async Task<List<Promocion>> PromosXestadoAsync(string estado)
        {
            var _context = CreateContext();
            return await _context.Promociones.Where(p => p.Estado == estado).ToListAsync();
        }
        public async Task<Promocion> AgregarNuevaPromoAsync(Promocion promocion)
        {
            var _context = CreateContext();
            await _context.Promociones.AddAsync(promocion);
            await _context.SaveChangesAsync();
            return promocion;
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

