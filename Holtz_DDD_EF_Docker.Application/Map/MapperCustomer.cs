using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Map.Interfaces;
using Holtz_DDD_EF_Docker.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Holtz_DDD_EF_Docker.Application.Map
{
    public class MapperCustomer : IMapperCustomer
    {
        public Customer MapperDtoToEntity(CustomerDto dto)
        {
            return new Customer
            { 
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            } ;
        }

        public CustomerDto MapperEntityToDto(Customer entity)
        {
            return new CustomerDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }

        public IEnumerable<CustomerDto> MapperListEntityToDto(IEnumerable<Customer> list)
        {
            return list.Select(c => MapperEntityToDto(c));
        }
    }
}
