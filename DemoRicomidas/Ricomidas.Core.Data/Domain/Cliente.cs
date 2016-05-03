using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ricomidas.Core.Data.Domain
{
    [Table("Cliente")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


        public virtual ICollection<Remision> Remisiones { get; set; }

    }
}