using System;
using Microsoft.EntityFrameworkCore;
using OpenMod.EntityFrameworkCore;
using OpenMod.EntityFrameworkCore.Configurator;

namespace MyOpenModPlugin;

public class UserConnectionDbContext : OpenModDbContext<UserConnectionDbContext>
{
        
    public DbSet<UserConnection> UserConnections => Set<UserConnection>();
        
    public UserConnectionDbContext(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public UserConnectionDbContext(IDbContextConfigurator configurator, IServiceProvider serviceProvider) : base(configurator, serviceProvider)
    {
    }
}