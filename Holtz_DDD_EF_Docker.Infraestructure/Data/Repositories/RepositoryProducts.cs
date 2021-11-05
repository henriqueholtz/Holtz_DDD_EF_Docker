using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories;
using Holtz_DDD_EF_Docker.Domain.Entities;

namespace Holtz_DDD_EF_Docker.Infraestructure.Data.Repositories
{
    public class RepositoryProducts : RepositoryBase<Product>, IRepositoryProducts
    {
        private readonly ApplicationContext _context;
        public RepositoryProducts(ApplicationContext applicationContext) : base(applicationContext)
        {
            _context = applicationContext;
        }
    }
}
