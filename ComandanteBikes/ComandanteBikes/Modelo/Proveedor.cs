using System.ComponentModel.DataAnnotations;

namespace ComandanteBikes.Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La Direccion es requerida")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "El Telefono es requerido")]
        [Range(0, 9999999999, ErrorMessage = "Maximo 10 digitos")]
        public long Telefono { get; set; }
        // Propiedades de navegacion EF
        virtual public ICollection<Producto>? Productos { get; set; }
    }
}
