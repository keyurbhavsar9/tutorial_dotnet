using Microsoft.EntityFrameworkCore;
using tutorial_dotnet.Models;

namespace tutorial_dotnet.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }


    }
}