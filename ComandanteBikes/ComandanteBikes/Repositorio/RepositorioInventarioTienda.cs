using ComandanteBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Repositorio
{
    public class RepositorioInventarioTienda : IRepositorioInventarioTienda
    {
        private readonly CatalogoDBContext _contexto;

        public RepositorioInventarioTienda(CatalogoDBContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<InventarioTienda> Add(InventarioTienda inventarioTienda)
        {
            await _contexto.InventarioTienda.AddAsync(inventarioTienda);
            await _contexto.SaveChangesAsync();
            return inventarioTienda;
        }
        public async Task Delete(int id)
        {
            var inventarioTienda = await _contexto.InventarioTienda.FindAsync(id);
            if (inventarioTienda != null)
            {
                _contexto.InventarioTienda.Remove(inventarioTienda);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<InventarioTienda?> Get(int id)
        {
            return await _contexto.InventarioTienda.FindAsync(id);
        }
        public async Task<List<InventarioTienda>> GetAll()
        {
            return await _contexto.InventarioTienda.ToListAsync();
        }
        public async Task Update(int id, InventarioTienda inventarioTienda)
        {
            var inventarioActual = await _contexto.InventarioTienda.FindAsync(id);
            if (inventarioActual != null)
            {
                inventarioActual.ModeloInventario = inventarioTienda.ModeloInventario;
                inventarioActual.ColorInventario = inventarioTienda.ColorInventario;
                inventarioActual.PrecioInventario = inventarioTienda.PrecioInventario;
                inventarioActual.TallaInventario = inventarioTienda.TallaInventario;
                inventarioActual.CantidadTotal = inventarioTienda.CantidadTotal;
                await _contexto.SaveChangesAsync();
            }
        }
    }

}

