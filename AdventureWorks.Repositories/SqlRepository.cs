using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AdventureWorks.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        public SqlRepository(DbContext context)
        {
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> FindAll()
        {
            return _dbSet;
        }

        public IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T Add(T newEntity)
        {
            return _dbSet.Add(newEntity);
        }

        public T Remove(T entity)
        {
            return _dbSet.Remove(entity);
        }

        protected DbSet<T> _dbSet;
    }
}
