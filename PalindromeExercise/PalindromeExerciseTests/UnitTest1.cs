using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("radar", true)]
        [InlineData("fish", false)]
        public void IsAPalindrome_Test(string word, bool expected)

        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
