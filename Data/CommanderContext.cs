using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=test_db;User Id=root;Password=root;");

        public DbSet<Command> Commands { get; set; }
    }
}