using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpenMod.Core.Commands;

namespace MyOpenModPlugin;

[Command("lastconnect")]
[CommandSyntax("<user id> <user type>")]
public class LastConnectCommand : Command
{
    private readonly UserConnectionDbContext m_DbContext;

    public LastConnectCommand(UserConnectionDbContext dbContext,
        IServiceProvider serviceProvider) : base(serviceProvider)
    {
        m_DbContext = dbContext;
    }

    protected override async Task OnExecuteAsync()
    {
        var userId = await Context.Parameters.GetAsync<string>(0);
        var userType = await Context.Parameters.GetAsync<string>(1);

        UserConnection? userConnection = await m_DbContext.UserConnections
            .Where(x => x.UserId == userId && x.UserType == userType)
            .OrderByDescending(x => x.ConnectionTime)
            .FirstOrDefaultAsync();

        if (userConnection == null)
        {
            await PrintAsync("This user has never connected.");
        }
        else
        {
            await PrintAsync($"Last connection: {userConnection.ConnectionTime}");
        }
    }
}