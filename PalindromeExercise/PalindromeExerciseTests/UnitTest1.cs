using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            [Theory]
            [InlineData("racecar", true)]
            [InlineData("toblerone", false)]
            [InlineData("RaceCar", true)]
            [InlineData("AManAPlanACanalPanama", true)]
            [InlineData("Teddy Roosevelt", false)]

            static void PalindromeTest(string input, bool expected)
            {
                var wordSmith = new WordSmith();

                var actual = WordSmith.IsAPalindrome(input);
                
                Assert.Equal(expected, actual);
            }
        }
    }
}
