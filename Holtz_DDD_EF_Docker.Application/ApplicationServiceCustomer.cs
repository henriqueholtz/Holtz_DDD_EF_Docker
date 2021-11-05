using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Interfaces;
using Holtz_DDD_EF_Docker.Application.Interfaces.Mappers;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
