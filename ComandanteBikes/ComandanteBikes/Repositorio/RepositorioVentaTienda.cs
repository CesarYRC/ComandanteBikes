using ComandanteBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Repositorio
{
    public class RepositorioVentaTienda : IRepositorioVentaTienda
    {
        private readonly CatalogoDBContext _contexto;

        public RepositorioVentaTienda(CatalogoDBContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<VentaTienda> Add(VentaTienda ventaTienda)
        {
            await _contexto.VentaTienda.AddAsync(ventaTienda);
            await _contexto.SaveChangesAsync();
            return ventaTienda;
        }
        public async Task Delete(int id)
        {
            var ventaTienda = await _contexto.VentaTienda.FindAsync(id);
            if (ventaTienda != null)
            {
                _contexto.VentaTienda.Remove(ventaTienda);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<VentaTienda?> Get(int id)
        {
            return await _contexto.VentaTienda.FindAsync(id);
        }
        public async Task<List<VentaTienda>> GetAll()
        {
            return await _contexto.VentaTienda.ToListAsync();
        }
        public async Task Update(int id, VentaTienda ventaTienda)
        {
            var ventaActual = await _contexto.VentaTienda.FindAsync(id);
            if (ventaActual != null)
            {
                ventaActual.NombreClienteVenta = ventaTienda.NombreClienteVenta;
                ventaActual.CorreoClienteVenta = ventaTienda.CorreoClienteVenta;
                ventaActual.TelefonoClienteVenta = ventaTienda.TelefonoClienteVenta;
                await _contexto.SaveChangesAsync();
            }
        }
    }
}

