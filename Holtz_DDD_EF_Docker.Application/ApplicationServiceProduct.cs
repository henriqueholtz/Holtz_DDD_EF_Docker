using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Interfaces;
using Holtz_DDD_EF_Docker.Application.Interfaces.Mappers;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Holtz_DDD_EF_Docker.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProducts
    {
        private readonly IServiceProducts _serviceProducts;
        private readonly IMapperProduct _mapper;
        public ApplicationServiceProduct(IServiceProducts serviceProducts, IMapperProduct mapperProduct)
        {
            _serviceProducts = serviceProducts;
            _mapper = mapperProduct;
        }
        public void Add(ProductDto dto)
        {
            _serviceProducts.Add(_mapper.MapperDtoToEntity(dto));
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return _serviceProducts.GetAll().Select(p => _mapper.MapperEntityToDto(p));
        }

        public ProductDto GetById(int id)
        {
            return _mapper.MapperEntityToDto(_serviceProducts.GetById(id));
        }

        public void Remove(int id)
        {
            _serviceProducts.Remove(id);
        }

        public void Update(ProductDto dto)
        {
            _serviceProducts.Update(_mapper.MapperDtoToEntity(dto));
        }
    }
}
