using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> readAll();
        T ReadById(int id);
        T create(T entity);
        T update(T entity);
        T delete(T entity);
    }
}
