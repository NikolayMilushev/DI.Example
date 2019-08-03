using DI.Example.Data.Abstract;
using DI.Example.Entities;
using DI.Example.Services.Abstract;
using System;
using System.Collections.Generic;

namespace DI.Example.Services.Concrete
{
    public class DIExampleService : IDIExampleService
    {
        private readonly IDIExampleRepository diExampleRepository;

        public DIExampleService(IDIExampleRepository diExampleRepository)
        {
            this.diExampleRepository = diExampleRepository;
        }
        public IEnumerable<ExampleEntity> GetAll()
        {
            var result = diExampleRepository.GetAll();
            return result;
        }

        public ExampleEntity Get(int id)
        {
            var result = diExampleRepository.Get(id);
            return result;
        }

    }
}
