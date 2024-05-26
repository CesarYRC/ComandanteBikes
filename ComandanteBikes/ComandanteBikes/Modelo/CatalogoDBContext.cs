using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Modelo
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options): base(options)
        {

        }
        public DbSet<ProductosTienda> ProductosTienda { get; set;}
    }
}
