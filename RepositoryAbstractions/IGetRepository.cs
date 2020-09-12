using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface IGetRepository<T>
    {
        /// <summary>
        /// Get all entities.
        /// </summary>
        /// <returns>
        /// All entities.
        /// </returns>
        Task<IList<T>> GetAllAsync();

        /// <summary>
        /// Get all entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <returns>Entities matched with the expression provided.</returns>
        Task<IList<T>> GetAllByConditionsAsync(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Get sorted entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <returns>Sorted entities matched with the expression provided.</returns>
        Task<IList<T>> GetAllByConditionsAsync<TKey>(Expression<Func<T, bool>> expression, Sort<T, TKey> sort);

        /// <summary>
        /// Get sorted and paginated entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <param name="pagination">Specification to paginate the entities to be retrieved.</param>
        /// <returns>Sorted and paginated entities matched with the expression provided.</returns>
        Task<IList<T>> GetAllByConditionsAsync<TKey>(Expression<Func<T, bool>> expression, Sort<T, TKey> sort, Pagination pagination);
    }
}
