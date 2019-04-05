using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class ValidParenthesesTest
    {
        [Fact]
        public void TestValidParentheses()
        {
            Assert.True(ValidParentheses.FindValidParentheses(""));
            Assert.True(ValidParentheses.FindValidParentheses("()"));
            Assert.True(ValidParentheses.FindValidParentheses("(())((()())())"));
            Assert.True(ValidParentheses.FindValidParentheses("(((()()())))"));
            Assert.True(ValidParentheses.FindValidParentheses("<><><>>>>><<<>>>"));
            Assert.True(ValidParentheses.FindValidParentheses("()()([{)"));

            Assert.False(ValidParentheses.FindValidParentheses("())()()()()()(()"));
            Assert.False(ValidParentheses.FindValidParentheses(")(()))"));
            Assert.False(ValidParentheses.FindValidParentheses("("));
            Assert.False(ValidParentheses.FindValidParentheses(")"));
            Assert.False(ValidParentheses.FindValidParentheses("()()()()()()()(()"));
            Assert.False(ValidParentheses.FindValidParentheses("()()(()"));
            Assert.False(ValidParentheses.FindValidParentheses("[{<("));
        }
    }
}
