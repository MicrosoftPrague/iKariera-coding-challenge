using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class StopGninnipsMySdrowTest
    {
        [Fact]
        public void TestStopGninnipsMySdrow()
        {
            var actual = StopGninnipsMySdrow.SpinWords("Welcome");
            Assert.Equal("emocleW", actual);

            actual = StopGninnipsMySdrow.SpinWords("Hey fellow warriors");
            Assert.Equal("Hey wollef sroirraw", actual);

            actual = StopGninnipsMySdrow.SpinWords("This is a test");
            Assert.Equal("This is a test", actual);

            actual = StopGninnipsMySdrow.SpinWords("This is another test");
            Assert.Equal("This is rehtona test", actual);

            actual = StopGninnipsMySdrow.SpinWords("You are almost to the last test");
            Assert.Equal("You are tsomla to the last test", actual);

            actual = StopGninnipsMySdrow.SpinWords("Just kidding there is still one more");
            Assert.Equal("Just gniddik ereht is llits one more", actual);
        }
    }
}
