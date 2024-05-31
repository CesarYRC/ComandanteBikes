using ComandanteBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly CatalogoDBContext _contexto;

        public RepositorioProductos(CatalogoDBContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<Producto> Add(Producto productosTienda)
        {
            await _contexto.Productos.AddAsync(productosTienda);
            await _contexto.SaveChangesAsync();
            return productosTienda;
        }
        public async Task Delete(int id)
        {
            var productosTienda = await _contexto.Productos.FindAsync(id);
            if (productosTienda != null)
            {
                _contexto.Productos.Remove(productosTienda);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<Producto?> Get(int id)
        {
            return await _contexto.Productos.FindAsync(id);
        }
        public async Task<List<Producto>> GetAll()
        {
            return await _contexto.Productos.ToListAsync();
        }
        public async Task<List<Producto>> GetProductosPorProveedor(int proveedorId)
        {
            return await _contexto.Productos
                .Where(p => p.ProveedorId == proveedorId)
                .ToListAsync();
        }
        public async Task Update(int id, Producto productos)
        {
            var productoActual = await _contexto.Productos.FindAsync(id);
            if (productoActual != null)
            {
                productoActual.Modelo = productos.Modelo;
                productoActual.Marca = productos.Marca;
                productoActual.Precio = productos.Precio;
                productoActual.Talla = productos.Talla;
                productoActual.Color = productos.Color;
                productoActual.ProveedorId = productos.ProveedorId;
                await _contexto.SaveChangesAsync();
            }
        }
    }
}

