﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryAbstractions.Extensions
{
    public static class RepositoryQueryableExtensions
    {
        public static async Task<IList<T>> ToListAsync<T>(this IQueryable<T> queryable)
        {
            return await ((IRepositoryQueryable<T>)queryable).ToListAsync();
        }
    }
}