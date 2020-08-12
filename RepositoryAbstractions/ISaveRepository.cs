using RepositoryAbstractions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface ISaveRepository<T>
    {
        Task SaveAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task SaveAsync(IList<T> entity);
        Task<UpdateManyResult> UpdateAsync(IList<T> entities);
        Task UpdateAsync(Expression<Func<T, bool>> expression, T entity);
    }
}
