using Microsoft.EntityFrameworkCore;

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
        }

        public List<T> readAll()
        {
            return context.Set<T>().AsNoTracking().ToList();
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
