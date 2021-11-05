using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using Holtz_DDD_EF_Docker.Domain.Entities;

namespace Holtz_DDD_EF_Docker.Domain.Services
{
    public class ServiceCustomers : ServiceBase<Customer>, IServiceCustomers
    {
        private readonly IRepositoryCustomers _repository;
        public ServiceCustomers(IRepositoryCustomers repositoryCustomers) : base(repositoryCustomers)
        {
            _repository = repositoryCustomers;
        }
    }
}
