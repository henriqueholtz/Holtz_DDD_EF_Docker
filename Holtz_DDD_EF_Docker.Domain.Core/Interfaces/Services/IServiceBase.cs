using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(int id);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
