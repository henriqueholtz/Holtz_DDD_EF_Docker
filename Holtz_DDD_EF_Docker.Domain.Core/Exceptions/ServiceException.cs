using System;

namespace Holtz_DDD_EF_Docker.Domain.Core.Exceptions
{
    public class ServiceException : Exception
    {
        public string Entity { get; set; }
        public ServiceException(string entity = null) : base()
        {
            Entity = entity;
        }
        public ServiceException(string message, Exception exception, string entity = null) : base(message, exception)
        {
            Entity = entity;
        }
        public ServiceException(string message, string entity = null) : base(message)
        {
            Entity = entity;
        }
    }
}