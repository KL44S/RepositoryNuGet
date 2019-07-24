using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface IDeleteRepository<T>
    {
        Task DeleteAllByConditionsAsync(Expression<Func<T, bool>> expression);
    }
}
