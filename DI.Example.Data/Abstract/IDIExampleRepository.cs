using DI.Example.Entities;
using System;
using System.Collections.Generic;

namespace DI.Example.Data.Abstract
{
    public interface IDIExampleRepository
    {
        IEnumerable<ExampleEntity> GetAll();
        ExampleEntity Get(int id);
    }
}
