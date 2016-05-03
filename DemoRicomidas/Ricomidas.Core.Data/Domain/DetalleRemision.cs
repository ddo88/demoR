using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ricomidas.Core.Data.Domain
{
    [Table("DetalleRemision")]
    public class DetalleRemision
    {
        [Key]
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }

    }
}