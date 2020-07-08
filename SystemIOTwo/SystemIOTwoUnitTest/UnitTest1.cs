using System;
using Xunit;
using static SystemIOTwo.Program;

namespace SystemIOTwoUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1 2 3", 6)]
        [InlineData("1 a 3", 3)]
        [InlineData("1 2", 0)]
        [InlineData("1 2 3 4", 6)]
        public void Test1(string input, int expected)
        {
            // Arrange
            // Act
            int actual = ChallengeOne(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
