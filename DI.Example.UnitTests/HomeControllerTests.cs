using DI.Example.Entities;
using DI.Example.Services.Abstract;
using DI.Example.Web.Controllers;
using DI.Example.Web.Models;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Xunit;

namespace DI.Example.UnitTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_NonEmptyList_ReturnsNonEmptyResult()
        {
            var expected = new ExampleEntityViewModel { Id = 99, Name = "Name 99" };
            var serviceMock = new Mock<IDIExampleService>();
            serviceMock
                .Setup(x => x.GetAll())
                .Returns(
                    new List<ExampleEntity> { new ExampleEntity { Id=99, Name = "Name 99"} } );

            var sut = new HomeController(serviceMock.Object);
            var actual = sut.Index() as ViewResult;

            Assert.NotNull(actual);
            Assert.IsType<ExampleEntitiesViewModel>(actual.Model);

            var model = actual.Model as ExampleEntitiesViewModel;
            Assert.NotNull(model.ExampleEntities);
            Assert.Single(model.ExampleEntities.ToList());
            Assert.Equal(99, model.ExampleEntities.ToList().First().Id);
            Assert.Equal("Name 99", model.ExampleEntities.ToList().First().Name);
        }
    }
}
