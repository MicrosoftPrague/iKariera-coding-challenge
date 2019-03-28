using Xunit;

namespace CodingChallenges.Tests
{
    public class BinaryAdditionTest
    {
        [Fact]
        public void TestBinaryAddition()
        {
            var sum = BinaryAddition.ComputeBinarySum(1, 2);
            Assert.Equal("11", sum);
        }
    }
}
