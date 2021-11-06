using Autofac;

namespace Holtz_DDD_EF_Docker.Infraestructure.CrossCutting.IOC
{
    public class ModuleIoc : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIoc.Load(builder);
        }
    }
}
