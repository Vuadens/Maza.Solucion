using Microsoft.EntityFrameworkCore;
using Maza.DomainModel;

namespace Maza.Data
{
    public class PromocionRepository : IPromocionRepository
    {
        private readonly PromocionesContext _context; //inyeccion del dbContext para que pueda ser usado
                                                      //en los metodos de la clase que estamos definiendo

        public PromocionRepository(PromocionesContext context)
        {
            _context = context;
        }

        public async Task<List<Promocion>> PromosXestadoAsync(string estado)
        {
            return await _context.Promociones.Where(p => p.Estado == estado).ToListAsync();
        }
        public async Task<Promocion> AgregarNuevaPromoAsync(Promocion promocion)
        {
            await _context.Promociones.AddAsync(promocion);
            await _context.SaveChangesAsync();
            return promocion;
        }
        public async Task<List<Promocion>> ExpirarPromoAsync(int promocionId)
        {

            var promocionAexpirar = await _context.Promociones.FindAsync(promocionId);
            if (promocionAexpirar != null)
            {
                promocionAexpirar.Estado = "Expirada";
                _context.Promociones.Update(promocionAexpirar); //la línea _context.Promociones.Update(promocionAexpirar) es innecesaria (no incorrecta)
                await _context.SaveChangesAsync();
                return await _context.Promociones.ToListAsync();
            }
            
            return await _context.Promociones.ToListAsync();
        }
    }           /*: como promocionAexpirar salió de FindAsync sobre el mismo _context, EF Core ya lo está "rastreando" 
                con solo cambiar promocionAexpirar.Estado = "Expirada" y llamar SaveChangesAsync() alcanza.*/
}

