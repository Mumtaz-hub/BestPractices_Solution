using BestPractices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BestPracticesTest
{
    public class SealedTest
    {
        [Fact]
        public void SealedClass_ShouldReturnsExpectedSequence()
        {
            // Arrange
            int expected = 30;

            // Act
            Point p1 = new Point(10, 20);
            int actual = p1.Display();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
