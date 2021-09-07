using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface IDeleteRepository<T>
    {
        /// <summary>
        /// Delete all entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to be deleted.</param>
        Task DeleteAllByConditionsAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    }
}