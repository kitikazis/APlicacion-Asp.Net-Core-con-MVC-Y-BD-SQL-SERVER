using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_ventas_ds504.Models
{
    [Table("tb_producto")]
    public class Producto
    {
        [Key]
        [Required(ErrorMessage = "Ingrese el código del producto")]
        [StringLength(5, ErrorMessage = "El código del producto debe tener {1} caracteres", MinimumLength = 5)]
        [Display(Name = "Código de Producto")]
        public string codigo_producto { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del producto")]
        [StringLength(40, ErrorMessage = "El nombre del producto no debe exceder de {1} caracteres")]
        [Display(Name = "Nombre del Producto")]
        public string producto { get; set; }

        [Required(ErrorMessage = "Ingrese el stock disponible")]
        [Display(Name = "Stock Disponible")]
        public int stock_disponible { get; set; }

        [Required(ErrorMessage = "Ingrese el costo del producto")]
        [Display(Name = "Costo")]
        [DataType(DataType.Currency)]
        public Double costo { get; set; }

        [Required(ErrorMessage = "Ingrese la ganancia del producto")]
        [Display(Name = "Ganancia")]
        public Double ganancia { get; set; }


        [Required(ErrorMessage = "Seleccione la marca del producto")]
        [Display(Name = "Marca")]
        public string producto_codigo_marca { get; set; }

        [Required(ErrorMessage = "Seleccione la categoría del producto")]
        [Display(Name = "Categoría")]
        public string producto_codigo_categoria { get; set; }

        [ForeignKey("producto_codigo_marca")]
        public virtual Marca Marca { get; set; }

        [ForeignKey("producto_codigo_categoria")]
        public virtual Categoria Categoria { get; set; }
    }
}
