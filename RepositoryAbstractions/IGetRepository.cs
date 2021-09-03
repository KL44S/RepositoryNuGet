using System;
using System.Linq;
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
        IQueryable<T> GetAll();

        /// <summary>
        /// Get all entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <returns>Entities matched with the expression provided.</returns>
        IQueryable<T> GetAllByConditions(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Get sorted entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <returns>Sorted entities matched with the expression provided.</returns>
        IQueryable<T> GetAllByConditions<TKey>(Expression<Func<T, bool>> expression, Sort<T, TKey> sort);

        /// <summary>
        /// Get sorted and paginated entities matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entities to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <param name="pagination">Specification to paginate the entities to be retrieved.</param>
        /// <returns>Sorted and paginated entities matched with the expression provided.</returns>
        IQueryable<T> GetAllByConditions<TKey>(Expression<Func<T, bool>> expression, Sort<T, TKey> sort, Pagination pagination);

        /// <summary>
        /// Get the first entity matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entity to retrieve.</param>
        /// <returns>First entity with the expression provided.</returns>
        Task<T> GetFirstByConditionsAsync(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Get the first entity matched with the expression provided.
        /// </summary>
        /// <param name="expression">Expression to find the entity to retrieve.</param>
        /// <param name="sort">Specification to sort the entities matched.</param>
        /// <returns>First of the sorted entities matched with the expression provided.</returns>
        Task<T> GetFirstByConditionsAsync<TKey>(Expression<Func<T, bool>> expression, Sort<T, TKey> sort);
    }
}
