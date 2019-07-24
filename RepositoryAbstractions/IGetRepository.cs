using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface IGetRepository<T>
    {
        Task<IList<T>> GetAllAsync();
        Task<IList<T>> GetAllByConditionsAsync(Expression<Func<T, bool>> expression);
        Task<IList<T>> GetAllByConditionsAsync<TKey>(Expression<Func<T, bool>> expression, Sort<T, TKey> sort);
        Task<IList<T>> GetAllByConditionsAsync<TKey>(Expression<Func<T, bool>> expression, Sort<T, TKey> sort, Pagination pagination);
    }
}
