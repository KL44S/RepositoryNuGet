﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace RepositoryAccess
{
    public interface ISaveRepository<T>
    {
        /// <summary>
        /// Insert the entity as a new entry.
        /// </summary>
        /// <param name="entity">Entity to be inserted.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        Task InsertAsync(T entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Insert multiple entities as new entries.
        /// </summary>
        /// <param name="entities">Entities to be inserted.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        Task InsertManyAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace the existing entity matched by the expression by the one provided as param. If replacement couldn't be done, a ReplaceException will be thrown.
        /// </summary>
        /// <param name="expression">Expression to search the entity to be replaced.</param>
        /// <param name="entity">New entity to replace the one matched with the expression.</param>
        /// <param name="cancellationToken">[Optional]Token used to cancel the task.</param>
        Task ReplaceAsync(Expression<Func<T, bool>> expression, T entity, CancellationToken cancellationToken = default);
    }
}