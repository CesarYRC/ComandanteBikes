using ComandanteBikes.Modelo;

namespace ComandanteBikes.Repositorio
{
    public interface IRepositorioVentaTienda
    {
        Task<List<VentaTienda>> GetAll();
        Task<VentaTienda> Get(int id);
        Task<VentaTienda> Add(VentaTienda ventaTienda);
        Task Update(int id, VentaTienda ventaTienda);
        Task Delete(int id);
    }
}
