using RevisaoApp.Domain.Interfaces.Repositories;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RevisaoApp.Repository.Repositories
{
    public abstract class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        private Context context { get; set; }

        public BaseRepository(Context context)
        {
            this.context = context;
        }

        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public int Count()
        {
            return context.Set<T>().Count();
        }

        public void Delete(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Deleted;
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Find(long id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>().AsQueryable();
        }

        public long LongCount()
        {
            return context.Set<T>().LongCount();
        }

        public void Update(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Modified;
            context.Set<T>().Attach(entity);
            context.SaveChanges();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> condition)
        {
            return context.Set<T>().Where(condition).AsQueryable();
        }
    }
}