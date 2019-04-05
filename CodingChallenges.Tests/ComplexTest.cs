using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class ComplexTest
    {
        [Fact]
        public void TestComplex()
        {
            Assert.True(Complex.IsComplex("2+3i"));
            Assert.True(Complex.IsComplex("2 + 3i"));
            Assert.True(Complex.IsComplex("2.0 - 3*i"));
            Assert.True(Complex.IsComplex("2 + 3 * i"));
            Assert.True(Complex.IsComplex("2.231 +3 * i"));
            Assert.True(Complex.IsComplex("i + 2"));
            Assert.True(Complex.IsComplex("i * 2"));
            Assert.True(Complex.IsComplex("i * 2.1"));

            Assert.False(Complex.IsComplex("2 + 3 * I"));
            Assert.False(Complex.IsComplex("3.123907f99896"));
            Assert.False(Complex.IsComplex("1 + 1"));
            Assert.False(Complex.IsComplex("--1"));
            Assert.False(Complex.IsComplex("valid number"));
        }
    }
}
