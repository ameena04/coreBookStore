using coreBookStore.Controllers;
using coreBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestPublication
{
    public class UnitTest1
    {
        PublicationController controller;
        BookStoreDbContext context;
        public UnitTest1()
        {
            controller = new PublicationController(context);
        }
        [Trait("Publication", "Index")]
        [Fact(DisplayName = "PublicationIndex")]
        public void Test1()
        {
            //Arrange
            //Act

            Assert.Throws<NullReferenceException>(() =>
            {
                IActionResult result = controller.Index();
                Assert.NotNull(result);
            });

        }

        [Trait("Publication", "Create")]
        [Fact(DisplayName = "PublicationCreate")]
        public void Test2()
        {
            ViewResult result = controller.Details();
            Assert.NotNull(result);
        }


       [Trait("Publication", "Details")]
        [Fact(DisplayName = "PublicationDetails")]
        public void Test3()
        {
            ActionResult result = (ViewResult)controller.Details();
                  
            Assert.IsInstanceOfType(result.Model, typeof(ViewResult));
            Assert.NotNull(result);
        }
    }
}
