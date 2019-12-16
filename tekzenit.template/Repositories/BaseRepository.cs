using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tekzenit.template.Context;
using tekzenit.template.Entities;

namespace tekzenit.template.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly TekDbContext dbContext;

        public BaseRepository(TekDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(T obj, bool saveChanges = true)
        {
            dbContext.Add(obj);
            if (saveChanges)
                dbContext.SaveChanges();
        }

        public void Delete(T obj, bool saveChanges = true)
        {
            dbContext.Remove(obj);
            if (saveChanges)
                dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().AsEnumerable();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(T obj, bool saveChanges = true)
        {
            dbContext.Set<T>().Update(obj);
            if (saveChanges)
                dbContext.SaveChanges();
        }
    }
}
