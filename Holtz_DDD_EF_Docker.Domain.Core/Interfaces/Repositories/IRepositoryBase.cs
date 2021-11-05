using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        bool Create(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
