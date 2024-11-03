using myLinqMethods;

namespace TestProject
{
    public class TestLinq
    {
        [Fact]
        public void TestSkipWhile()
        {
            // 1. Arrange
            int[] array = { 2, 4, 2, 5, -4, 5, 2, -9, 8, 6 };

            // 2. Act
            IEnumerable<int> result = array.MySkipWhile(x => x > 0);

            // 3. Assert
            Assert.Equal(new[] { -4, 5, 2, -9, 8, 6 }, result);
        }

    }
}