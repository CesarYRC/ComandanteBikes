using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Modelo
{
    public class CatalogoDBContext : DbContext
    {
        internal object inventarioTienda;

        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options): base(options)
        {

        }
        public DbSet<ProductosTienda> ProductosTienda { get; set;}
        public DbSet<InventarioTienda> InventarioTienda { get; set;}
        public DbSet<VentaTienda> VentaTienda { get; set;}
    }
}
