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

        [Fact]
        public void StringConcatenetate_ShouldReturnsExpectedSequence_UsingConcatMethod()
        {
            // Arrange
            string string1 = "Hello";
            string string2 = "World";
            string expected = "HelloWorld";

            // Act
            string actual = StringConcatenate.UsingConcatMethod(string1, string2);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void StringConcatenetate_ShouldReturnsExpectedSequence_UsingFormatMethod()
        {
            // Arrange
            string string1 = "Hello";
            string string2 = "World";
            string expected = "HelloWorld";

            // Act
            string actual = StringConcatenate.UsingFormatMethod(string1, string2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StringConcatenetate_ShouldReturnsExpectedSequence_UsingInterpolation()
        {
            // Arrange
            string string1 = "Hello";
            string string2 = "World";
            string expected = "HelloWorld";

            // Act
            string actual = StringConcatenate.UsingInterpolation(string1, string2);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void StringConcatenetate_ShouldReturnsExpectedSequence_usingStringBUilder()
        {
            // Arrange
            string string1 = "Hello";
            string string2 = "World";
            string expected = "HelloWorld";

            // Act
            string actual = StringConcatenate.UsingStringBuilder(string1, string2);

            // Assert
            Assert.Equal(expected, actual);
        }

       
        
    }
}
