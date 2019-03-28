using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class LargestPrimeFactorTest
    {
        [Fact]
        public void TestLargestPrimeFactor()
        {
            Assert.Equal(6857, LargestPrimeFactor.GetLargestPrimeFactor());
        }
    }
}
