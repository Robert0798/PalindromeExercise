using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void Test1(string word, bool expected)
        {
            var tester = new Palindrome();
            
            bool actual = tester.IsPalindrome(word);
            
            Assert.Equal(expected, actual);

        }
    }
}
