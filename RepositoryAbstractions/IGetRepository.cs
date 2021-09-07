using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface IGetRepository<T>
    {
        /// <summary>
        /// Get all entities.
        /// </summary>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        /// <returns>
        /// All entities.
        /// </returns>
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        /// <returns>Entities matched with the expression provided.</returns>
        Task<IEnumerable<T>> GetAllByConditionsAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get sorted entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        /// <returns>Sorted entities matched with the expression provided.</returns>
        Task<IEnumerable<T>> GetAllByConditions<TKey>(
            Expression<Func<T, bool>> expression, 
            Sort<T, TKey> sort,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get sorted and paginated entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <param name="pagination">Specification to paginate the entities to be retrieved.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        /// <returns>Sorted and paginated entities matched with the expression provided.</returns>
        Task<IEnumerable<T>> GetAllByConditions<TKey>(
            Expression<Func<T, bool>> expression, 
            Sort<T, TKey> sort, 
            Pagination pagination,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the first entity matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entity to retrieve.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        /// <returns>First entity with the expression provided.</returns>
        Task<T> GetFirstByConditionsAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the first entity matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entity to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        /// <returns>First of the sorted entities matched with the expression provided.</returns>
        Task<T> GetFirstByConditionsAsync<TKey>(
            Expression<Func<T, bool>> expression, 
            Sort<T, TKey> sort, 
            CancellationToken cancellationToken = default);
    }
}
