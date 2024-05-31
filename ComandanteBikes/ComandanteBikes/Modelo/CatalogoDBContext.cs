using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Modelo
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options): base(options)
        {

        }
        public DbSet<Producto> Productos { get; set;}
        public DbSet<Proveedor> Proveedores { get; set;}
        public DbSet<Venta> Ventas { get; set;}
    }
}
