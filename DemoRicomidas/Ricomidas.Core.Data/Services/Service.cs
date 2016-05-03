using System.Collections.Generic;

namespace Ricomidas.Core.Data.Services
{
    public interface Service<T>
    {

        T GetById(int id);

        ICollection<T> GetAll(); 
        void Insert(T element);
        void Update(T element);
        void Delete(T element);
    }
}