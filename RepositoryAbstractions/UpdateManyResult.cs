using System.Collections.Generic;

namespace RepositoryAbstractions
{
    public class UpdateManyResult
    {
        public IList<string> SuccessfulIds { get; set; }
        public IList<string> FailedIds { get; set; }
    }
}