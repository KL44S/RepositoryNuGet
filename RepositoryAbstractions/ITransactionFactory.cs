using System;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAbstractions
{
    public interface ITransaction
    {
        void StartTransaction();
        void AbortTransaction();
        void CommitTransaction();
    }

    public interface ITransactionFactory : IDisposable
    {
        Task<ITransaction> CreateTransactionAsync(CancellationToken cancellationToken);
    }
}
