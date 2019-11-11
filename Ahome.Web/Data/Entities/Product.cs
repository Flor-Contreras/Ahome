using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ahome.Web.Data.Entities
{
    public class Product
    {
       [Key]
       public int ProductId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50,ErrorMessage = "El campo {0} debe máximo {1} caracteres")]
        [Display(Name = "Producto")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(150, ErrorMessage = "El campo {0} debe máximo {1} caracteres")]
        [Display(Name = "Descripcion del producto")]
        public string Description { get; set; }
    }
}
