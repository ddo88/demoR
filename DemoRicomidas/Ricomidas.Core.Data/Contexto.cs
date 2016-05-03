using System.Data.Entity;
using Ricomidas.Core.Data.Domain;

namespace Ricomidas.Core.Data
{
    public class Contexto : DbContext
    {
        public Contexto():base("name=Ricomidas")
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Remision> Remisiones { get; set; }
        public DbSet<DetalleRemision> DetallesRem { get; set; }

    }
}