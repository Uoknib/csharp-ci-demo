using Xunit;

namespace MyApp.Tests
{
    public class AddTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            int result = Program.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
