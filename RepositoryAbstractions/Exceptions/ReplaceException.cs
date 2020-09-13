using System;

namespace RepositoryAbstractions.Exceptions
{
    public class ReplaceException : Exception
    {
        public ReplaceException(string message) : base(message) { }
    }
}