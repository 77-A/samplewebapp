using NUnit.Framework;
using SampleWebApp.Pages;

namespace SampleWebAppTests
{
    public class SampleTests : BaseTests
    {
        [Test]
        public void OnGet()
        {
            // Arrange
            var model = new SampleModel(_configuration);

            // Act
            model.OnGet("Environment");

            // Assert
            Assert.IsNotNull(model.Value);
            Assert.AreEqual(model.Value, "Local");
        }
    }
}