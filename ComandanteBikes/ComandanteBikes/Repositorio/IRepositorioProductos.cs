using ComandanteBikes.Modelo;

namespace ComandanteBikes.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> GetAll();

        Task<Producto?> Get(int id);
        Task<Producto> Add(Producto productosTienda);
        Task Update(int id, Producto productosTienda);
        Task Delete(int id);
        Task<List<Producto>> GetProductosPorProveedor(int proveedorId);
    }
}
