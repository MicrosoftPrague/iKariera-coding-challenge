using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class EvenFibonacciNumbersTest
    {
        [Fact]
        public void TestEvenFibonacciNumbers()
        {
            var actual = EvenFibonacciNumbers.GetSum();
            Assert.Equal(4613732, actual);
        }
    }
}
