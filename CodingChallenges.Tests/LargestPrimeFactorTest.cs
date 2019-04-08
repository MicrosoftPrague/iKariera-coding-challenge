using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class LargestPrimeFactorTest
    {
        [Fact]
        public void TestLargestPrimeFactor()
        {
            var actual = LargestPrimeFactor.GetLargestPrimeFactor();
            Assert.Equal(6857, actual);
        }
    }
}
