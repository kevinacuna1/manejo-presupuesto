using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name = "Tipo de Cuenta")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        /** Pruebas de otras validaciones por defecto **/
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El campo {0} debe ser un correo electrónico válido")]
        public string Email { get; set; }
        [Range(minimum: 18, maximum: 100, ErrorMessage = "La {0} debe estar entre {1} y {2}")]
        public int Edad { get; set; }
        [Url(ErrorMessage = "El campo {0} debe ser una URL válida")]
        public string URL { get; set; }
        [CreditCard(ErrorMessage = "El campo {0} debe ser un número de tarjeta de crédito válido")]
        public string TarjetaDeCredito { get; set; }
    }
}
