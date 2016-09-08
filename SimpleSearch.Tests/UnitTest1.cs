using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MySearchApp.Models.Entities;
using SimpleSearch.Controllers;
using SimpleSearch.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SimpleSearch.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IPersonRepository> _mockRepository;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPersonRepository>();

        }
        [TestMethod]
        public void Search()
        {
            string SearchString = "t";
            _mockRepository.Setup(s => s.GetPersons(SearchString)).Returns(new List<Person> { new Person { FirstName = "TestName" } });
            var controller = new HomeController(_mockRepository.Object);
            var result = controller.Search(SearchString);
            Assert.IsTrue(result.GetType() == typeof(JsonResult));
        }
    }
}
