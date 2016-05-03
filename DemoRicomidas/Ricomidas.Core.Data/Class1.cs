using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricomidas.Core.Data
{

    //Buscar sobre EntityFramework Code First
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
    }

    public class Remision
    {

        public int Id { get; set; }
        public string Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int MyProperty { get; set; }

    }


    public class Contexto : DbContext
    {
        public Contexto():base("Model=BaseDatos")
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }



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
        public string Direccion { get; set; }

    }


    public class DetalleRemision
    {
        public int Id { get; set; }
        public string IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }



}
