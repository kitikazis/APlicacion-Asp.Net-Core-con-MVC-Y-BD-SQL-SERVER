using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("tb_venta")]
    public class Venta
    {
        [Key]
        [Required(ErrorMessage = "Ingrese el código de venta")]
        [StringLength(5, ErrorMessage = "El código de venta debe tener {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Código de Venta")]
        public string codigo_venta { get; set; }

        [Required(ErrorMessage = "Ingrese la fecha de la venta")]
        [Display(Name = "Fecha de Venta")]
        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "Ingrese el código del cliente")]
        [StringLength(5, ErrorMessage = "El código del cliente debe tener {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Código del Cliente")]
        public string venta_codigo_cliente { get; set; }

        [Required(ErrorMessage = "Ingrese el monto de la venta")]
        [Display(Name = "Monto")]
        public double monto { get; set; }

        [Required(ErrorMessage = "Ingrese el IGV")]
        [Display(Name = "IGV")]
        public double igv { get; set; }
    }
}
