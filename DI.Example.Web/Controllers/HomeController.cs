using DI.Example.Entities;
using DI.Example.Services.Abstract;
using DI.Example.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DI.Example.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDIExampleService diExampleService;

        public HomeController(IDIExampleService diExampleService)
        {
            this.diExampleService = diExampleService;
        }
        public ActionResult Index()
        {
            var entity = diExampleService.GetAll();
            var viewModel = Map(entity);
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var entity = diExampleService.Get(id);
            var viewModel = Map(entity);
            return View(viewModel);
        }

        private ExampleEntitiesViewModel Map(IEnumerable<ExampleEntity> entity)
        {
            var result = new ExampleEntitiesViewModel
            {
                ExampleEntities = entity
                                .Select(x => new ExampleEntityViewModel { Id = x.Id, Name = x.Name })
            };
            return result;
        }

        private ExampleEntityViewModel Map(ExampleEntity entity)
        {
            var result = new ExampleEntityViewModel { Id = entity.Id, Name = entity.Name };
            return result;
        }

    }
}