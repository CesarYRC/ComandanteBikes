using ComandanteBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ComandanteBikes.Repositorio
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        private readonly CatalogoDBContext _contexto;

        public RepositorioProveedores(CatalogoDBContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<Proveedor> Add(Proveedor inventarioTienda)
        {
            await _contexto.Proveedores.AddAsync(inventarioTienda);
            await _contexto.SaveChangesAsync();
            return inventarioTienda;
        }
        public async Task Delete(int id)
        {
            var inventarioTienda = await _contexto.Proveedores.FindAsync(id);
            if (inventarioTienda != null)
            {
                _contexto.Proveedores.Remove(inventarioTienda);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<Proveedor?> Get(int id)
        {
            return await _contexto.Proveedores.FindAsync(id);
        }
        public async Task<List<Proveedor>> GetAll()
        {
            return await _contexto.Proveedores.ToListAsync();
        }
        public async Task Update(int id, Proveedor proveedor)
        {
            var proveedorActual = await _contexto.Proveedores.FindAsync(id);
            if (proveedorActual != null)
            {
                proveedorActual.Nombre = proveedor.Nombre;
                proveedorActual.Direccion = proveedor.Direccion;
                proveedorActual.Telefono = proveedor.Telefono;
                await _contexto.SaveChangesAsync();
            }
        }
    }

}

