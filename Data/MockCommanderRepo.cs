using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and pan",},
                new Command { Id = 1, HowTo = "Make coffee", Line = "Boil water, grind beans", Platform = "Kettle and cup", },
                new Command { Id = 2, HowTo = "Make tea", Line = "Place teabag in cup", Platform = "Cup", }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and pan", };

        }
    }
}