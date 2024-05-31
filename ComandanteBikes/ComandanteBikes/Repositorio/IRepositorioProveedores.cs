using ComandanteBikes.Modelo;

namespace ComandanteBikes.Repositorio
{
    public interface IRepositorioProveedores
    {
        Task<List<Proveedor>> GetAll();
        Task<Proveedor?> Get(int id);
        Task<Proveedor> Add(Proveedor inventarioTienda);
        Task Update(int id, Proveedor inventarioTienda);
        Task Delete(int id);
    }
}
