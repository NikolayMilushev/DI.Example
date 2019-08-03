using DI.Example.Entities;
using System.Collections.Generic;

namespace DI.Example.Services.Abstract
{
    public interface IDIExampleService
    {
        IEnumerable<ExampleEntity> GetAll();

        ExampleEntity Get(int id);
    }
}