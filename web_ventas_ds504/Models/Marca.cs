using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("tb_marca")]
    public class Marca
    {
        [Key]
        [Required(ErrorMessage = "Ingrese el código de la marca")]
        [StringLength(5, ErrorMessage = "El código de la marca debe tener {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Código de Marca")]
        public string codigo_marca { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la marca")]
        [StringLength(30, ErrorMessage = "El nombre de la marca no debe exceder {1} caracteres")]
        [Display(Name = "Marca")]
        public string marca { get; set; }
    }
}
