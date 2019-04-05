using System.Collections.Generic;
using Xunit;

namespace CodingChallenges.Tests
{
    public class PersistenceOfNumbersTest
    {
        [Fact]
        public void TestPersistenceOfNumbers()
        {
            var actual = PersistenceOfNumbers.ComputePersistence(39);
            Assert.Equal(3, actual);

            actual = PersistenceOfNumbers.ComputePersistence(4);
            Assert.Equal(0, actual);

            actual = PersistenceOfNumbers.ComputePersistence(25);
            Assert.Equal(2, actual);

            actual = PersistenceOfNumbers.ComputePersistence(999);
            Assert.Equal(4, actual);
        }
    }
}
