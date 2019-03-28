using Xunit;

namespace CodingChallenges.Tests
{
    public class PalindromeTest
    {
        [Fact]
        public void TestPalindrome()
        {
            Assert.True(Palindrome.IsPalindrome("Madam"));
            Assert.True(Palindrome.IsPalindrome("Redder"));
            Assert.True(Palindrome.IsPalindrome("Sagas"));
            Assert.True(Palindrome.IsPalindrome("Kayak"));
            Assert.True(Palindrome.IsPalindrome("Racecar"));

            Assert.False(Palindrome.IsPalindrome("Step"));
            Assert.False(Palindrome.IsPalindrome("lemon"));
            Assert.False(Palindrome.IsPalindrome("pets"));
            Assert.False(Palindrome.IsPalindrome("cave"));
            Assert.False(Palindrome.IsPalindrome("melon"));
        }
    }
}
