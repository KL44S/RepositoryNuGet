using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAbstractions
{
    public interface IRepositoryQueryable<T> : IQueryable<T>
    {
        Task<IList<T>> ToListAsync(CancellationToken cancellationToken = default);
    }
}
