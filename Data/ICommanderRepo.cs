using System.Collections.Generic;
using tutorial_dotnet.Models;
namespace tutorial_dotnet.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandByID(int id);

    }
}