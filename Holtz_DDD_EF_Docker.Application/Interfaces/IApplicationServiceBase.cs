using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.Application.Interfaces
{
    public interface IApplicationServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity dto);
        void Update(TEntity dto);
        void Remove(int id);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
