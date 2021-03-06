using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories;
using Holtz_DDD_EF_Docker.Domain.Entities;

namespace Holtz_DDD_EF_Docker.Infraestructure.Data.Repositories
{
    public class RepositoryCustomers : RepositoryBase<Customer>, IRepositoryCustomers
    {
        public readonly ApplicationContext _context;
        public RepositoryCustomers(ApplicationContext applicationContext) : base(applicationContext)
        {
            _context = applicationContext;
        }
    }
}
