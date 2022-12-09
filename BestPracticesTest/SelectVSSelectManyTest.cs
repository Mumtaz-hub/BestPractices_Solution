using BestPractices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BestPracticesTest
{
    public class SelectVSSelectManyTest
    {
        [Fact]
        public void Select_ShouldReturnsExpectedSequence()
        {
            // Arrange
            var list = new List<string> { "1", "2", "3" };
            var expected = new List<string> { "1a", "2a", "3a" };

            // Act
            var actual = SelectVSSelectMany.Select(list);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SelectMany_ShouldReturnsExpectedSequence()
        {
            // Arrange
            var list = new List<string> { "1", "2", "3" };
            var expected = "1a2a3a" ;

            // Act
            var actual = SelectVSSelectMany.SelectMany(list);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Select_SelectMany_ShouldReturnsExpectedSequence()
        {
            // Arrange
            var numbers = new List<List<int>>
            {
                new List<int> { 1, 1, 1 },
                new List<int> { 2, 2, 2 },
                new List<int> { 3, 3, 3 }
            };
            
            var expected = new List<int> { 1, 1, 1, 4, 4, 4, 9, 9, 9 };

            // Act
            var actual = SelectVSSelectMany.select_selectmany(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
