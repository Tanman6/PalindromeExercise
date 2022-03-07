using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Testset", true)]
        [InlineData("Rotor", true)]
        [InlineData("Name", false)]
        public void IsAPalindrome(string str, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            //Act
            bool actual = wordSmith.IsAPalindrome(str);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
