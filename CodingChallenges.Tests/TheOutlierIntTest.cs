using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class TheOutlierIntTest
    {
        [Fact]
        public void TestTheOutlierInt()
        {
            var numbers = new[] { 2, 6, 8, -10, 3 };
            var actual = TheOddInt.Find(numbers);
            Assert.Equal(3, actual);

            numbers = new[] { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            actual = TheOddInt.Find(numbers);
            Assert.Equal(206847684, actual);

            numbers = new[] { int.MaxValue, 0, 1 };
            actual = TheOddInt.Find(numbers);
            Assert.Equal(0, actual);
        }
    }
}
