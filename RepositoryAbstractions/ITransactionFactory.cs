using System;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAbstractions
{
    public interface ITransaction : IDisposable
    {
        Task StartTransactionAsync(CancellationToken cancellationToken);
        Task AbortTransactionAsync(CancellationToken cancellationToken);
        Task CommitTransactionAsync(CancellationToken cancellationToken);
    }

    public interface ITransactionFactory
    {
        Task<ITransaction> CreateTransactionAsync(CancellationToken cancellationToken);
    }
}
