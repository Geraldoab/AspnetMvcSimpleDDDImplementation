using RevisaoApp.Domain.Interfaces.Repositories;
using RevisaoApp.Domain.Interfaces.Services;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RevisaoApp.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            this._repository = repositoryBase;
        }

        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public int Count()
        {
            return _repository.Count();
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public T Find(long id)
        {
            return _repository.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public long LongCount()
        {
            return _repository.LongCount();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> condition)
        {
            return _repository.Where(condition);
        }
    }
}