using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ricomidas.Core.Data.Domain
{
    [Table("Producto")]
    //Buscar sobre EntityFramework Code First
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }

        public virtual ICollection<DetalleRemision> Remisiones { get; set; }
    }
}