using System;
using System.Linq.Expressions;

namespace RepositoryAccess
{
    public class Sort<T, TKey>
    {
        public Expression<Func<T, TKey>> SortExpression { get; set; }
        public SortType SortType { get; set; }

        public Sort(Expression<Func<T, TKey>> sortExpression, SortType sortType)
        {
            this.SortExpression = SortExpression;
            this.SortType = sortType;
        }
    }
}
