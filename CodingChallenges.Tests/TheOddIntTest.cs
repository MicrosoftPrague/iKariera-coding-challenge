using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class TheOddIntTest
    {
        [Fact]
        public void TestTheOddInt()
        {
            var numbers = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            var actual = TheOddInt.Find(numbers);
            Assert.Equal(5, actual);

            numbers = new[] { 20, 1, -1, -1, -1, 5, 5, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            actual = TheOddInt.Find(numbers);
            Assert.Equal(5, actual);

            numbers = new[] { 20, 1, -1, -1, -1, 5, 5, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 20, 20, 4, -1, -2, 5 };
            actual = TheOddInt.Find(numbers);
            Assert.Equal(5, actual);

            numbers = new[] { -1, -1, -1, -1, 0, 0, 0, 0, 0, 1, 1, 1, 1 };
            actual = TheOddInt.Find(numbers);
            Assert.Equal(0, actual);
        }
    }
}
