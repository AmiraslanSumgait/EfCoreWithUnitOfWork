using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Context;
using UnitOfWork.DataAccess.Repositories.Abstract;

namespace UnitOfWork.DataAccess.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected MyDbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(MyDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return from entity in _dbSet
                   select entity;
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> exp)
        {
            return _dbSet.Where(exp);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
