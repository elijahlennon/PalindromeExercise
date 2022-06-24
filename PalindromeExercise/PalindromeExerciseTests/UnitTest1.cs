using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("kayak", true)]
        [InlineData("madam", true)]
        [InlineData("star rats", true)]
        [InlineData("elijah", false)]
        [InlineData("nurses run", true)]
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var tester = new WordSmith();

            //act
            var actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
