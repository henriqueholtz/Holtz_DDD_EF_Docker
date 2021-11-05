using System;

namespace Holtz_DDD_EF_Docker.Domain.Core.Exceptions
{
    public class RepositoryException : Exception
    {
        public string Entity { get; set; }

        public RepositoryException(string entity = null) : base() 
        {
            Entity = entity;
        }
        public RepositoryException(string message, string entity = null) : base(message)
        {
            Entity = entity;
        }
        public RepositoryException(string? message, Exception exception, string entity = null) : base(message, exception)
        {
            Entity = entity;
        }
    }
}
