using Holtz_DDD_EF_Docker.Domain.Core.Exceptions;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repository = repositoryBase;
        }
        public bool Add(TEntity entity)
        {
            try
            {
                return _repository.Create(entity);
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.ToString(), ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.ToString(), ex);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.ToString(), ex);
            }
        }

        public bool Remove(int id)
        {
            try
            {
                TEntity entity = _repository.GetById(id);
                return _repository.Remove(entity);
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.ToString(), ex);
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                return _repository.Update(entity);
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.ToString(), ex);
            }
        }
    }
}
