using System;
using System.Linq.Expressions;

namespace RepositoryAccess
{
    public class Sort<T, TKey>
    {
        public Expression<Func<T, TKey>> SortExpression { get; set; }
        public SortType SortType { get; set; }
    }
}
