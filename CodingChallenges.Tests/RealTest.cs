using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class RealTest
    {
        [Fact]
        public void TestReal()
        {
            Assert.True(Real.IsReal("2"));
            Assert.True(Real.IsReal("1111"));
            Assert.True(Real.IsReal("12.57"));
            Assert.True(Real.IsReal("0"));
            Assert.True(Real.IsReal("42"));
            Assert.True(Real.IsReal("     42"));

            Assert.False(Real.IsReal("3.14.1"));
            Assert.False(Real.IsReal("+1"));
            Assert.False(Real.IsReal("22-"));
            Assert.False(Real.IsReal("--1"));
            Assert.False(Real.IsReal("valid number"));
        }
    }
}
