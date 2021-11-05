using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Interfaces.Mappers;
using Holtz_DDD_EF_Docker.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Holtz_DDD_EF_Docker.Application.Map
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDtoToEntity(ProductDto dto)
        {
            return new Product
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                Quantity = dto.Quantity
            };
        }

        public ProductDto MapperEntityToDto(Product entity)
        {
            return new ProductDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Quantity = entity.Quantity
            };
        }

        public IEnumerable<ProductDto> MapperListEntityToDto(IEnumerable<Product> list)
        {
            return list.Select(p => MapperEntityToDto(p));
        }
    }
}
