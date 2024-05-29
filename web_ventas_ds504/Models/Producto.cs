using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using web_ventas_ds504.Models;

[Table("tb_producto")]
public class Producto
{
    [Key]
    [Required(ErrorMessage = "Ingrese el código del producto")]
    [StringLength(5, ErrorMessage = "El código del producto debe tener {1} caracteres", MinimumLength = 5)]
    [Display(Name = "Código de Producto")]
    public string CodigoProducto { get; set; }

    [Required(ErrorMessage = "Ingrese el nombre del producto")]
    [StringLength(40, ErrorMessage = "El nombre del producto no debe exceder de {1} caracteres")]
    [Display(Name = "Nombre del Producto")]
    public string producto { get; set; }

    [Required(ErrorMessage = "Ingrese el stock disponible")]
    [Display(Name = "Stock Disponible")]
    public int StockDisponible { get; set; }

    [Required(ErrorMessage = "Ingrese el costo del producto")]
    [Display(Name = "Costo")]
    [DataType(DataType.Currency)]
    public double Costo { get; set; }

    [Required(ErrorMessage = "Ingrese la ganancia del producto")]
    [Display(Name = "Ganancia")]
    public double Ganancia { get; set; }

    [Required(ErrorMessage = "Seleccione la marca del producto")]
    [Display(Name = "Marca")]
    public string ProductoCodigoMarca { get; set; }

    [Required(ErrorMessage = "Seleccione la categoría del producto")]
    [Display(Name = "Categoría")]
    public string ProductoCodigoCategoria { get; set; }

    [ForeignKey("ProductoCodigoMarca")]
    public virtual Marca Marca { get; set; }

    [ForeignKey("ProductoCodigoCategoria")]
    public virtual Categoria Categoria { get; set; }
}