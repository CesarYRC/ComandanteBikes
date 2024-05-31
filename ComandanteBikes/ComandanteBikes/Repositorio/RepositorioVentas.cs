using ComandanteBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Repositorio
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly CatalogoDBContext _contexto;

        public RepositorioVentas(CatalogoDBContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<Venta> Add(Venta ventaTienda)
        {
            await _contexto.Ventas.AddAsync(ventaTienda);
            await _contexto.SaveChangesAsync();
            return ventaTienda;
        }
        public async Task Delete(int id)
        {
            var ventaTienda = await _contexto.Ventas.FindAsync(id);
            if (ventaTienda != null)
            {
                _contexto.Ventas.Remove(ventaTienda);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<Venta?> Get(int id)
        {
            return await _contexto.Ventas.FindAsync(id);
        }
        public async Task<List<Venta>> GetAll()
        {
            return await _contexto.Ventas.ToListAsync();
        }
        public async Task Update(int id, Venta venta)
        {
            var ventaActual = await _contexto.Ventas.FindAsync(id);
            if (ventaActual != null)
            {
                ventaActual.NombreCliente = venta.NombreCliente;
                ventaActual.CorreoCliente = venta.CorreoCliente;
                ventaActual.TelefonoCliente = venta.TelefonoCliente;
                ventaActual.ProductoId = venta.ProductoId;
                await _contexto.SaveChangesAsync();
            }
        }
    }
}

