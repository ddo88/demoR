using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ricomidas.Core.Data.Domain
{
    [Table("Remision")]
    public class Remision
    {

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }


    }
}