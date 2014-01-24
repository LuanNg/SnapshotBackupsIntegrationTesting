using System;
using System.Linq;
using System.Linq.Expressions;

namespace AdventureWorks.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate);
        T Add(T newEntity);
        T Remove(T entity);
    }
}
