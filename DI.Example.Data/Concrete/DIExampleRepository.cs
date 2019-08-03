using DI.Example.Data.Abstract;
using DI.Example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI.Example.Data.Concrete
{
    public class DIExampleRepository : IDIExampleRepository
    {
        private readonly DIExampleDbContext diExampleDbContext;

        public DIExampleRepository(DIExampleDbContext diExampleDbContext)
        {
            this.diExampleDbContext = diExampleDbContext;
        }

        public ExampleEntity Get(int id)
        {
            return this.diExampleDbContext.ExampleEntity.Where(x => x.Id == id).FirstOrDefault();            
        }

        public IEnumerable<ExampleEntity> GetAll()
        {
            return this.diExampleDbContext.ExampleEntity.ToList();
        }
    }
}
