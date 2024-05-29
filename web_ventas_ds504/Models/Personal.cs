using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace web_ventas_ds504.Models
{
    [Table ("tb_personal")]
    public class Personal
    {
        [Key]
        [Required(ErrorMessage = "Escriba numero de DNI")]
        [MinLength(8, ErrorMessage = "Escriba 8 digitos")]
        [Display(Name  = "Numero DNI")]

        public String dni { get; set; }

        [Required(ErrorMessage = "Escriba apellido paterno")]
        [StringLength(25)]
        [Display(Name = "Apellido paterno")]

        public String ap_paterno { get; set; }

        [Required(ErrorMessage = "Escriba apellido materno")]
        [StringLength(25)]
        [Display(Name = "Apellido materno")]

        public String ap_materno { get; set; }

        [Required(ErrorMessage = "Escriba nombre")]
        [StringLength(25)]
        [Display(Name = "Nombre")]

        public String nombre { get; set; }

        [Display(Name = "Genero")]

        public String genero { get; set; }


        [Required(ErrorMessage = "Elija fecha de nacimiento")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]

        public DateTime fecha_nacimiento { get; set;}

        [Required(ErrorMessage = "Ingrese sueldo")]
        [Display(Name = "Sueldo")]

        public double sueldo { get; set; }
    }
}
