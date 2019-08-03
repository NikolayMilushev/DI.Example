using DI.Example.Data.Concrete;
using DI.Example.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Example.Data.Migrations
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DIExampleDbContext>
    {
        protected override void Seed(DIExampleDbContext context)
        {
            IList<ExampleEntity> defaultEntities = new List<ExampleEntity>();


            defaultEntities.Add(new ExampleEntity { Id = 1, Name = "Example 1" });
            defaultEntities.Add(new ExampleEntity { Id = 2, Name = "Example 2" });
            defaultEntities.Add(new ExampleEntity { Id = 3, Name = "Example 3" });
            defaultEntities.Add(new ExampleEntity { Id = 4, Name = "Example 4" });
            context.ExampleEntity.AddRange(defaultEntities);

            base.Seed(context);
        }
    }
}
