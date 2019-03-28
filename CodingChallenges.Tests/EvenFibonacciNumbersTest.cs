using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class EvenFibonacciNumbersTest
    {
        [Fact]
        public void TestEvenFibonacciNumbers()
        {
            Assert.Equal(4613732, EvenFibonacciNumbers.GetSum());
        }
    }
}
