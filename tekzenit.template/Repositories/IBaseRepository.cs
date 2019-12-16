using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tekzenit.template.Repositories
{
    public interface IBaseRepository<T> 
    {
        void Add(T obj, bool saveChanges = true);
        void Update(T obj, bool saveChanges = true);
        void Delete(T obj, bool saveChanges = true);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
