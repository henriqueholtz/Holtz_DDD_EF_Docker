using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.Infraestructure.CrossCutting.Interfaces
{
    public interface IMapperBase<TEntity, TEntityDto> where TEntity : class
    {
        TEntity MapperDtoToEntity(TEntityDto dto);
        IEnumerable<TEntityDto> MapperListEntityToDto(IEnumerable<TEntity> list);
        TEntityDto MapperEntityToDto(TEntity entity);
    }
}
