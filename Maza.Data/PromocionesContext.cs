using Microsoft.EntityFrameworkCore;
using Maza.DomainModel;

namespace Maza.Data
{
    public class PromocionesContext : DbContext
    {
        public DbSet<Promocion> Promociones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=dbPromocion;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
