using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Interfaces;
using Holtz_DDD_EF_Docker.Application.Map.Interfaces;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.Application
{
    public class ApplicationServiceCustomer : IApplicationServiceCustomers
    {
        private readonly IServiceCustomers _serviceCustomers;
        private readonly IMapperCustomer _mapper;
        public ApplicationServiceCustomer(IServiceCustomers serviceCustomers)
        {
            _serviceCustomers = serviceCustomers;
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
