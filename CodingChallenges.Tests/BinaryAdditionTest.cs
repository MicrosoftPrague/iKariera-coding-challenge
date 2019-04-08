using Xunit;

namespace CodingChallenges.Tests
{
    public class BinaryAdditionTest
    {
        [Fact]
        public void TestBinaryAddition()
        {
            var actual = BinaryAddition.ComputeBinarySum(1, 2);
            Assert.Equal("11", actual);
        }
    }
}
