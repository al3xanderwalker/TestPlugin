using OpenMod.API.Plugins;
using OpenMod.EntityFrameworkCore.MySql.Extensions;

namespace MyOpenModPlugin;

public class PluginContainerConfigurator : IPluginContainerConfigurator
{
    public void ConfigureContainer(IPluginServiceConfigurationContext context)
    {
        // You can extend how your database context works by using the overloads of this method.
        context.ContainerBuilder.AddMySqlDbContext<UserConnectionDbContext>();
    }
}