using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class MultiplierOf3And5Test
    {
        [Fact]
        public void TestMultiplierOf3And5()
        {
            var actual = MultiplierOf3And5.ComputeSum();
            Assert.Equal(233168, actual);
        }
    }
}
