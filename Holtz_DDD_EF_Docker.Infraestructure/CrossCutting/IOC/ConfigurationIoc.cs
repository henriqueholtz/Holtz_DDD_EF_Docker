using Autofac;
using Holtz_DDD_EF_Docker.Application;
using Holtz_DDD_EF_Docker.Application.Interfaces;
using Holtz_DDD_EF_Docker.Application.Interfaces.Mappers;
using Holtz_DDD_EF_Docker.Application.Map;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Repositories;
using Holtz_DDD_EF_Docker.Domain.Core.Interfaces.Services;
using Holtz_DDD_EF_Docker.Domain.Services;
using Holtz_DDD_EF_Docker.Infraestructure.Data.Repositories;

namespace Holtz_DDD_EF_Docker.Infraestructure.CrossCutting.IOC
{
    public class ConfigurationIoc
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            // Application Services
            builder.RegisterType<ApplicationServiceCustomer>().As<IApplicationServiceCustomers>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProducts>();


            // Services
            builder.RegisterType<ServiceCustomers>().As<IServiceCustomers>();
            builder.RegisterType<ServiceProducts>().As<IServiceProducts>();


            // Repositories
            builder.RegisterType<RepositoryCustomers>().As<IRepositoryCustomers>();
            builder.RegisterType<RepositoryProducts>().As<IRepositoryProducts>();


            //Mappers
            builder.RegisterType<MapperCustomer>().As<IMapperCustomer>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();

            #endregion
        }
    }
}
