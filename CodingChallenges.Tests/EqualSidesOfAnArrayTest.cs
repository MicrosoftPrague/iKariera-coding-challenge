using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class EqualSidesOfAnArrayTest
    {
        [Fact]
        public void TestEqualSidesOfAnArray()
        {
            var numbers = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            var actual = EqualSidesOfAnArray.FindEvenIndex(numbers);
            Assert.Equal(3, actual);

            numbers = new int[] { 1, 100, 50, -51, 1, 1 };
            actual = EqualSidesOfAnArray.FindEvenIndex(numbers);
            Assert.Equal(1, actual);

            numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            actual = EqualSidesOfAnArray.FindEvenIndex(numbers);
            Assert.Equal(-1, actual);

            numbers = new int[] { 20, 10, 30, 10, 10, 15, 35 };
            actual = EqualSidesOfAnArray.FindEvenIndex(numbers);
            Assert.Equal(3, actual);
        }
    }
}
