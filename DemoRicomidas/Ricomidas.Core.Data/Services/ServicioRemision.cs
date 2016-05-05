using Ricomidas.Core.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricomidas.Core.Data.Services
{
    public class ServicioRemision : IService<Remision>
    {
        public void Delete(Remision element)
        {
            using (var context = new Contexto())
            {

                var client = context.Remisiones.FirstOrDefault(x => x.Id == element.Id);
                if (client != null)
                {
                    context.Remisiones.Remove(client);
                    context.SaveChanges();
                }
            }
        }

        public ICollection<Remision> GetAll()
        {
            throw new NotImplementedException();
        }

        public Remision GetById(int id)
        {
            using (var context = new Contexto())
            {
                var remis = context.Remisiones.FirstOrDefault(x => x.Id == id);
                if (remis != null)
                {
                    return remis;
                }
            }

            return new Remision();
        }

        public void Insert(Remision element)
        {
            using (var context=new Contexto())
            {
                if (context.Remisiones.Any(x => x.Id == element.Id))
                {
                    context.Remisiones.Add(element);
                    context.SaveChanges();
                } 
            }
        }

        public void Update(Remision element)
        {
            using (var context = new Contexto())
            {

                var remis = context.Remisiones.FirstOrDefault(x => x.Id == element.Id);
                if (remis != null)
                {

                    remis.Nit = element.Nit;
                    remis.Nombre = element.Nombre;
                    remis.Telefono = client.Telefono;
                    remis.Direccion = client.Direccion;

                    context.SaveChanges();
                }
            }
        }
    }
}
