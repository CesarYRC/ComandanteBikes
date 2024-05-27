using System.ComponentModel.DataAnnotations;

namespace ComandanteBikes.Modelo
{
    public class VentaTienda
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del cliente es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? NombreClienteVenta { get; set; }
        [Required(ErrorMessage = "El correo del cliente es requerido")]
        [EmailAddress(ErrorMessage = "Inserta un correo valido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? CorreoClienteVenta { get; set; }
        [Required(ErrorMessage = "El Telefono del cliente es requerido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? TelefonoClienteVenta { get; set;}

    }
}
