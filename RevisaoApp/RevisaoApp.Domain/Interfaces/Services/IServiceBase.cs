using System;
using System.Linq;
using System.Linq.Expressions;

namespace RevisaoApp.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : class
    {
        T Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> GetAll();
        int Count();
        long LongCount();
        T Find(long id);
        IQueryable<T> Where(Expression<Func<T, bool>> condition);
    }
}
