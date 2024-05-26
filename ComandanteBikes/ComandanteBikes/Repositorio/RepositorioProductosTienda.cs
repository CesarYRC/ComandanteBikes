using ComandanteBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Repositorio
{
    public class RepositorioProductosTienda : IRepositorioProductosTienda
    {
        private readonly CatalogoDBContext _contexto;

        public RepositorioProductosTienda(CatalogoDBContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<ProductosTienda> Add(ProductosTienda productosTienda)
        {
            await _contexto.ProductosTienda.AddAsync(productosTienda);
            await _contexto.SaveChangesAsync();
            return productosTienda;
        }
        public async Task Delete(int id)
        {
            var productosTienda = await _contexto.ProductosTienda.FindAsync(id);
            if (productosTienda != null)
            {
                _contexto.ProductosTienda.Remove(productosTienda);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<ProductosTienda?> Get(int id)
        {
            return await _contexto.ProductosTienda.FindAsync(id);
        }
        public async Task<List<ProductosTienda>> GetAll()
        {
            return await _contexto.ProductosTienda.ToListAsync();
        }
        public async Task Update(int id, ProductosTienda productosTienda)
        {
            var productoActual = await _contexto.ProductosTienda.FindAsync(id);
            if (productoActual != null)
            {
                productoActual.Modelo = productosTienda.Modelo;
                productoActual.Marca = productosTienda.Marca;
                productoActual.Precio = productosTienda.Precio;
                productoActual.Talla = productosTienda.Talla;
                productoActual.Color = productosTienda.Color;
                await _contexto.SaveChangesAsync();
            }
        }
    }
}

