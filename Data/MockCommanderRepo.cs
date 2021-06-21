using System.Collections.Generic;
using tutorial_dotnet.Models;
namespace tutorial_dotnet.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command { id = 0, HowTo = "Boil agg", Line = "Boil Water", Platform = "Sample" },
                new Command { id = 1, HowTo = "Make Tea", Line = "Boil Oil", Platform = "Kettle" },
                new Command { id = 2, HowTo = "Take Knife", Line = "Boil Wine", Platform = "Nothing" }
            };

            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command { id = 0, HowTo = "Boil agg", Line = "Boil Water", Platform = "Sample" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}