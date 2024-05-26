using System.ComponentModel.DataAnnotations;

namespace ComandanteBikes.Modelo
{
    public class ProductosTienda
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Modelo de Bicicleta es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")] 
        public string? Modelo  { get; set; }
        [Required(ErrorMessage = "La marca de bicicleta es requerido ")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Marca { get; set; }
        [Required(ErrorMessage = "El precio de la bicicleta es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Precio { get; set; }
        [Required(ErrorMessage = "La talla de la bicicleta es requerido")]
        [StringLength(10, ErrorMessage = "Maximo 10 caracteres")]
        public string? Talla { get; set; }
        [Required(ErrorMessage = "El color de la bicicleta es requerido")]
        [StringLength(20, ErrorMessage = "Maximo 20 caracteres")]
        public string? Color { get; set; }
    }
}
