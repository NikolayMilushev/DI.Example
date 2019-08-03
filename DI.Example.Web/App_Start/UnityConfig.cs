using DI.Example.Data.Abstract;
using DI.Example.Data.Concrete;
using DI.Example.Services.Abstract;
using DI.Example.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Injection;

namespace DI.Example.Web.App_Start
{
    public static class UnityConfig
    {
        public static UnityContainer Container = new UnityContainer();
        public static void RegisterComponents()
        {
            Container.RegisterType<IDIExampleService, DIExampleService>();
            Container.RegisterType<IDIExampleRepository, DIExampleRepository>();
            Container.RegisterType<DIExampleDbContext>(
                new InjectionConstructor(
                    ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString));

            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
        }
    }
}