using System;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAbstractions
{
    public interface ITransaction
    {
        Task StartTransactionAsync();
        Task AbortTransactionAsync();
        Task CommitTransactionAsync();
    }

    public interface ITransactionFactory : IDisposable
    {
        Task<ITransaction> CreateTransactionAsync(CancellationToken cancellationToken);
    }
}
