using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class WeightForWeightTest
    {
        [Fact]
        public void TestWeightForWeight()
        {
            var actual = WeightForWeight.OrderByWeight("103 123 4444 99 2000");
            Assert.Equal("2000 103 123 4444 99", actual);

            actual = WeightForWeight.OrderByWeight("2000 10003 1234000 44444444 9999 11 11 22 123");
            Assert.Equal("11 11 2000 10003 22 123 1234000 44444444 9999", actual);
        }
    }
}
