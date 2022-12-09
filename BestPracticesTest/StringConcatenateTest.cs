using BestPractices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BestPracticesTest
{
    public class StringConcatenateTest
    {
        [Fact]
        public void StringConcatenetate_ShouldReturnsExpectedSequence_usingPlusOperator()
        {
            // Arrange
            string string1 = "Hello";
            string string2 = "World";
            string expected = "HelloWorld";

            // Act
            string actual = StringConcatenate.UsingPlusOperator(string1, string2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
