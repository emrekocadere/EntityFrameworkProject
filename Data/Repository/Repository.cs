using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly DataContext context = new DataContext();
        public T create(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
            //return entity;
        }

        public List<T> readAll()
        {
            return context.Set<T>().ToList();
        }

        public T ReadById(int id)
        {
           return context.Set<T>().Find(id);
        }

        public T update(T entity)
        {
            return entity;
        }

    }
}
