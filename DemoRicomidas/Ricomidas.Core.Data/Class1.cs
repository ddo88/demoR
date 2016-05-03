using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricomidas.Core.Data
{
    
    //Buscar sobre EntityFramework Code First

    public class Contexto : DbContext
    {
        public Contexto():base("Model=BaseDatos")
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }

    }

    //public class Test
    //{
    //    public Test()
    //    {
    //        new Contexto().Clientes.Where(x => x.Nombre == "Pepito");
    //    }
    //}


    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Telefono { get; set; }

    }



}
