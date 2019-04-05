using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class SplitStringsTest
    {
        [Fact]
        public void TestSplitStrings()
        {
            var actual = SplitStrings.SplitIt("abc");
            Assert.Equal(new string[] { "ab", "c_" }, actual);

            actual = SplitStrings.SplitIt("abcdef");
            Assert.Equal(new string[] { "ab", "cd", "ef" }, actual);
        }
    }
}
