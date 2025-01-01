using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using scontainers.Controllers;

namespace mytestscontainers
{
    public class Tests
    {
        //private ILogger<HomeController> logger;
        [SetUp]
        public void Setup()
        {
            //this.logger = ILogger<HomeController>();
        }

        [Test]
        public void Test_Index()
        {
            //Mock<HomeController> mock = new Mock<HomeController>();
            HomeController controller = new HomeController();
            //mock.Setup(x => x.Index()).Returns(controller.Index());


            var result = controller.Index() as ViewResult;

            Assert.That(result?.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void Test_Privacy()
        {
            HomeController controller = new HomeController();

            var result = controller.Privacy() as ViewResult;

            Assert.That(result?.ViewName, Is.EqualTo("Privacy"));
        }

        [Test]
        public void Test_Privacy_ViewData()
        {
            HomeController controller = new HomeController();

            var result = controller.Privacy() as ViewResult;

            Assert.That(result?.ViewData["abc"]?.ToString(), Is.EqualTo("SomeValue"));
        }
    }
}