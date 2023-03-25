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

    public interface ITransactionFactory
    {
        Task<ITransaction> CreateTransactionAsync(CancellationToken cancellationToken);
    }
}
