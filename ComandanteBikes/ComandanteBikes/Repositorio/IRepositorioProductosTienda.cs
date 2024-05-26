using ComandanteBikes.Modelo;

namespace ComandanteBikes.Repositorio
{
    public interface IRepositorioProductosTienda
    {
        Task<List<ProductosTienda>> GetAll();

        Task<ProductosTienda?> Get(int id);
        Task<ProductosTienda> Add(ProductosTienda productosTienda);
        Task Update(int id,ProductosTienda productosTienda);
        Task Delete(int id);
    }
}
