using Xunit;

namespace CodingChallenges.Tests
{
    public class HighestAndLowestTest
    {
        [Fact]
        public void TestHighestAndLowest()
        {
            var actual = HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");
            Assert.Equal("42 -9", actual);
        }
    }
}
