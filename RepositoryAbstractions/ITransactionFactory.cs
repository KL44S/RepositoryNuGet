using System;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAbstractions
{
    public interface ITransaction : IDisposable
    {
        Task StartTransactionAsync();
        Task AbortTransactionAsync();
        Task CommitTransactionAsync();
    }

    public interface ITransactionFactory
    {
        Task<ITransaction> CreateTransactionAsync(CancellationToken cancellationToken);
    }
}
