using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Interfaces;
using Holtz_DDD_EF_Docker.Application.Interfaces.Mappers;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Holtz_DDD_EF_Docker.Application
{
    public class ApplicationServiceCustomer : IApplicationServiceCustomers
    {
        private readonly IServiceCustomers _serviceCustomers;
        private readonly IMapperCustomer _mapper;
        public ApplicationServiceCustomer(IServiceCustomers serviceCustomers, IMapperCustomer mapperCustomer)
        {
            _serviceCustomers = serviceCustomers;
            _mapper = mapperCustomer;
        }
        
        public void Add(CustomerDto dto)
        {
            var customer = _mapper.MapperDtoToEntity(dto);
            _serviceCustomers.Add(customer);
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            return _serviceCustomers.GetAll().Select(c => _mapper.MapperEntityToDto(c));
        }

        public CustomerDto GetById(int id)
        {
            return _mapper.MapperEntityToDto(_serviceCustomers.GetById(id));
        }

        public void Remove(int id)
        {
            _serviceCustomers.Remove(id);
        }

        public void Update(CustomerDto dto)
        {
            _serviceCustomers.Update(_mapper.MapperDtoToEntity(dto));
        }
    }
}
