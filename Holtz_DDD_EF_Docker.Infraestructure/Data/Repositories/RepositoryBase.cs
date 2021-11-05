using Holtz_DDD_EF_Docker.Domain.Core.Exceptions;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Holtz_DDD_EF_Docker.Infraestructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _context;
        public RepositoryBase(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        public bool Create(TEntity entity)
        {
            try
            {
                _context.Add<TEntity>(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.ToString(), ex);
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.ToString(), ex);
            }
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.ToString(), ex);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.ToString(), ex);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return _context.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.ToString(), ex);
            }
        }

    }
}
