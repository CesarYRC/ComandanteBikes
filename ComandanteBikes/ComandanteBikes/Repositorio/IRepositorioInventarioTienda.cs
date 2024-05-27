using ComandanteBikes.Modelo;

namespace ComandanteBikes.Repositorio
{
    public interface IRepositorioInventarioTienda
    {
        Task<List<InventarioTienda>> GetAll();
        Task<InventarioTienda?> Get(int id);
        Task<InventarioTienda> Add(InventarioTienda inventarioTienda);
        Task Update(int id,  InventarioTienda inventarioTienda);
        Task Delete(int id);
    }
}
