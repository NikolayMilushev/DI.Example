using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Example.Web.Models
{
    public class ExampleEntitiesViewModel
    {
        public IEnumerable<ExampleEntityViewModel> ExampleEntities { get; set; }
    }
}