using System.ComponentModel.DataAnnotations;

namespace ComandanteBikes.Modelo
{
    public class InventarioTienda
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Modelo es requerido")]
        [StringLength(100,ErrorMessage = "Maximo 100 caracteres")]
        public string? ModeloInventario { get; set; }
        [Required(ErrorMessage = "El Color es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? ColorInventario { get; set; }
        [Required(ErrorMessage = "El Precio es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? PrecioInventario { get; set; }
        [Required(ErrorMessage = "La Talla es requerida")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? TallaInventario { get; set; }
        [Required(ErrorMessage = "La Cantidad Total es requerida(No mas de 100)")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? CantidadTotal { get; set; }
    }
}
