using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class PigLatinTest
    {
        [Fact]
        public void TestPigLatin()
        {
            var actual = PigLatin.PigIt("Pig latin is cool");
            Assert.Equal("igPay atinlay siay oolcay", actual);

            actual = PigLatin.PigIt("This is my string");
            Assert.Equal("hisTay siay ymay tringsay", actual);
        }
    }
}
