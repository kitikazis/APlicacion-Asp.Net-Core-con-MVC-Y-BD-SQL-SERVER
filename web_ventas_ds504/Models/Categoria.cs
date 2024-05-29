using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("tb_categoria")]
    public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "Ingrese el código de la categoría")]
        [StringLength(5, ErrorMessage = "El código de la categoría debe tener {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Código de Categoría")]
        public string codigo_categoria { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la categoría")]
        [StringLength(30, ErrorMessage = "El nombre de la categoría no debe exceder de {1} caracteres")]
        [Display(Name = "Nombre de la Categoría")]
        public string categoria { get; set; }
    }
}
