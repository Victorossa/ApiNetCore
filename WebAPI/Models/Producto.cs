using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }

        public int CategoriaID { get; set; }

        public int UnidadDeMedidaID { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreProducto { get; set; }

        public decimal Precio { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}