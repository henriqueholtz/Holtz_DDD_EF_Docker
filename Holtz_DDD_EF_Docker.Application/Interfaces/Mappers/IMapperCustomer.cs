using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Domain.Entities;

namespace Holtz_DDD_EF_Docker.Application.Interfaces.Mappers
{
    public interface IMapperCustomer : IMapperBase<Customer, CustomerDto>
    {
    }
}
