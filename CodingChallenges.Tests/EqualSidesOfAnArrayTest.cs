using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class EqualSidesOfAnArrayTest
    {
        [Fact]
        public void TestEqualSidesOfAnArray()
        {
            var actual = EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 });
            Assert.Equal(3, actual);

            actual = EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 });
            Assert.Equal(1, actual);

            actual = EqualSidesOfAnArray.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.Equal(-1, actual);

            actual = EqualSidesOfAnArray.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 });
            Assert.Equal(3, actual);
        }
    }
}
