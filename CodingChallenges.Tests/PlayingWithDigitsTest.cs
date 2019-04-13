using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class PlayingWithDigitsTest
    {
        [Fact]
        public void TestPlayingWithDigits()
        {
            var actual = PlayingWithDigits.ComputeNumber(89, 1);
            Assert.Equal(1, actual);

            actual = PlayingWithDigits.ComputeNumber(92, 1);
            Assert.Equal(-1, actual);

            actual = PlayingWithDigits.ComputeNumber(695, 2);
            Assert.Equal(2, actual);

            actual = PlayingWithDigits.ComputeNumber(46288, 3);
            Assert.Equal(51, actual);
        }
    }
}
