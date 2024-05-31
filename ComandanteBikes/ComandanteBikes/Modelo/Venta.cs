using System.ComponentModel.DataAnnotations;

namespace ComandanteBikes.Modelo
{
    public class Venta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del cliente es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? NombreCliente { get; set; }
        [Required(ErrorMessage = "El correo del cliente es requerido")]
        [EmailAddress(ErrorMessage = "Ingresa un correo valido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? CorreoCliente { get; set; }
        [Required(ErrorMessage = "El Telefono del cliente es requerido")]
        [Range(0, 9999999999, ErrorMessage = "Maximo 10 digitos")]
        public long TelefonoCliente { get; set; }
        // Propiedades de navegacion EF
        [Required(ErrorMessage = "El Producto es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El Producto es requerido")]
        public int ProductoId { get; set; }
        virtual public Producto? Producto { get; set; }
    }
}
