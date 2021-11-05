using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using Holtz_DDD_EF_Docker.Domain.Entities;

namespace Holtz_DDD_EF_Docker.Domain.Services
{
    public class ServiceProducts : ServiceBase<Product>, IServiceProducts
    {
        private readonly IRepositoryProducts _repository;
        public ServiceProducts(IRepositoryProducts repositoryProducts) : base(repositoryProducts)
        {
            _repository = repositoryProducts;
        }
    }
}
