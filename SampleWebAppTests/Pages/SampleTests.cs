using NUnit.Framework;
using SampleWebApp.Pages;
using System;

namespace SampleWebAppTests
{
    public class SampleTests : BaseTests
    {
        [Test]
        public void WhenOnGet()
        {
            // Arrange
            var model = new SampleModel(_configuration);

            // Act
            model.OnGet("Environment");

            // Assert
            Assert.IsNotNull(model.Value);
            Assert.AreEqual(model.Value, "Local");
        }

        [Test]
        public void WhenOnGetAndNameEmptyThrowArgumentNullException()
        {
            // Arrange
            var model = new SampleModel(_configuration);

            // Assert
            Assert.Throws<ArgumentNullException>(
                () => model.OnGet(string.Empty));
        }
    }
}