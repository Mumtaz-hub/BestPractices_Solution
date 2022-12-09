using BestPractices_Yieldreturn;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace BestPracticesTest
{
    public class YieldTest
    {
        [Fact]
        public void GenerateNumbers_ReturnsExpectedSequence()
        {
            // Arrange
            var expected = new[] { 1, 2, 3 };

            // Act
            var result = Yield.GenerateNumbers();

            // Assert
            Assert.Equal(expected, result);
        }
    }
}