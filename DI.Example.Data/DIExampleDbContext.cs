using DI.Example.Data.Migrations;
using DI.Example.Entities;
using System.Data.Entity;

namespace DI.Example.Data.Concrete
{
    public class DIExampleDbContext : DbContext
    {
        public DIExampleDbContext()
        {

        }

        public DIExampleDbContext(string connectionString)
            :base(connectionString)
        {
            Database.SetInitializer(new DatabaseInitializer());            
        }

        public DbSet<ExampleEntity> ExampleEntity { get; set; }
    }
}