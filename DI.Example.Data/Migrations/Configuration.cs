namespace DI.Example.Data.Migrations
{
    using DI.Example.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DI.Example.Data.Concrete.DIExampleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DI.Example.Data.Concrete.DIExampleDbContext context)
        {
        }
    }
}
