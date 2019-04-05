using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class ReverseOrRotateTest
    {
        [Fact]
        public void TestReverseOrRotate()
        {
            var actual = ReverseOrRotate.Compute("1234", 0);
            Assert.Equal("", actual);

            actual = ReverseOrRotate.Compute("", 0);
            Assert.Equal("", actual);

            actual = ReverseOrRotate.Compute("1234", 5);
            Assert.Equal("", actual);

            actual = ReverseOrRotate.Compute("733049910872815764", 5);
            Assert.Equal("330479108928157", actual);

            actual = ReverseOrRotate.Compute("123456987654", 6);
            Assert.Equal("234561876549", actual);

            actual = ReverseOrRotate.Compute("123456987653", 6);
            Assert.Equal("234561356789", actual);

            actual = ReverseOrRotate.Compute("66443875", 4);
            Assert.Equal("44668753", actual);

            actual = ReverseOrRotate.Compute("66443875", 8);
            Assert.Equal("64438756", actual);

            actual = ReverseOrRotate.Compute("664438769", 8);
            Assert.Equal("67834466", actual);

            actual = ReverseOrRotate.Compute("123456779", 8);
            Assert.Equal("23456771", actual);

            actual = ReverseOrRotate.Compute("563000655734469485", 4);
            Assert.Equal("0365065073456944", actual);
        }
    }
}
