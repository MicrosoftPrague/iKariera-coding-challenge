using Xunit;

namespace CodingChallenges.Tests
{
    public class BuildTowerTest
    {
        [Fact]
        public void TestBuildTower()
        {
            var expected = string.Join(",", new[] { "*" });
            var actual = string.Join(",", BuildTower.TowerBuilder(1));
            Assert.Equal(expected, actual);

            expected = string.Join(",", new[] { " * ", "***" });
            actual = string.Join(",", BuildTower.TowerBuilder(2));
            Assert.Equal(expected, actual);

            expected = string.Join(",", new[] { "  *  ", " *** ", "*****" });
            actual = string.Join(",", BuildTower.TowerBuilder(3));
            Assert.Equal(expected, actual);
        }
    }
}
