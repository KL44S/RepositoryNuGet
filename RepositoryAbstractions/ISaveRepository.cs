using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface ISaveRepository<T>
    {
        Task SaveAsync(T entity);
        Task SaveAsync(IList<T> entity);
        Task UpdateAsync(Expression<Func<T, bool>> expression, T entity);
        Task UpdateAsync(Expression<Func<T, bool>> expression, IList<T> entity);
    }
}
