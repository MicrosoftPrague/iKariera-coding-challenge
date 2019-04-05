using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class PrimeTest
    {
        [Fact]
        public void TestPrime()
        {
            Assert.True(Prime.IsPrime(-5347));
            Assert.True(Prime.IsPrime(5347));
            Assert.True(Prime.IsPrime(2));
            Assert.True(Prime.IsPrime(3));
            Assert.True(Prime.IsPrime(524287));

            Assert.False(Prime.IsPrime(4));
            Assert.False(Prime.IsPrime(99999));
            Assert.False(Prime.IsPrime(42));
            Assert.False(Prime.IsPrime(22));
            Assert.False(Prime.IsPrime(15));
        }
    }
}
