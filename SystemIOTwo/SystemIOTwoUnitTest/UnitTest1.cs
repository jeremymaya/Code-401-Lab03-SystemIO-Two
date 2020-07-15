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
        [InlineData("-1 2 3", -6)]
        [InlineData("-1 2 0", 0)]
        public void ChallengeOneTests(string input, int expected)
        {
            // Arrange
            // Act
            int actual = GetProduct(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 1, 2 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 2)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void ChallengeTwoTests(int[] arr, int expected)
        {
            // Arrange
            // Act
            int actual = GetAverage(arr, arr.Length);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 3)]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 4)]
        public void ChallengeTwoTestConfirmInput(int[] arr, int expected)
        {
            // Arrange
            // Act
            int actual = arr.Length;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 4 }, 4)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4 }, 1)]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4, 4 }, 1)]
        public void ChallengeFourTests(int[] arr, int expected)
        {
            // Arrange
            // Act
            int actual = GetMostFrequent(arr);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
