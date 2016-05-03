using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ricomidas.Core.Data.Domain;

namespace Ricomidas.Core.Data.Services
{
    public class ServicioCliente:Service<Cliente>
    {
        
        public Cliente GetById(int id)
        {
            using (var context = new Contexto())
            {
                var client = context.Clientes.FirstOrDefault(x => x.Id == id);
                if (client != null)
                {
                    return client;
                }
            }

            return new Cliente();
        }

        public ICollection<Cliente> GetAll()
        {
            using (var context = new Contexto())
            {
                return context.Clientes.ToList();
            }
        }

        public void Insert(Cliente element)
        {
            using (var context = new Contexto())
            {

                if (!context.Clientes.Any(x => x.Nit == element.Nit))
                {
                    context.Clientes.Add(element);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Cliente element)
        {
            using (var context = new Contexto())
            {

                var client = context.Clientes.FirstOrDefault(x => x.Id == element.Id);
                if (client != null)
                {
                    context.Clientes.Remove(client);
                    context.SaveChanges();
                }
            }
        }

        public void Update(Cliente element)
        {
            using (var context = new Contexto())
            {

                var client = context.Clientes.FirstOrDefault(x => x.Id == element.Id);
                if (client != null)
                {

                    client.Nit = cliente.Nit;
                    client.Nombre = cliente.Nombre;
                    client.Telefono = client.Telefono;
                    client.Direccion = client.Direccion;

                    context.SaveChanges();
                }
            }
        }
    }


    
}
