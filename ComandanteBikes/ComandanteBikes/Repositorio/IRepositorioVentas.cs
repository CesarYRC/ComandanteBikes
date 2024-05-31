using ComandanteBikes.Modelo;

namespace ComandanteBikes.Repositorio
{
    public interface IRepositorioVentas
    {
        Task<List<Venta>> GetAll();
        Task<Venta> Get(int id);
        Task<Venta> Add(Venta ventaTienda);
        Task Update(int id, Venta ventaTienda);
        Task Delete(int id);
    }
}
