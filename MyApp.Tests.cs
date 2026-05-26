using Xunit;

namespace MyApp.Tests
{
    public class AddTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            // 直接调用 Program 类中的 Add 方法（需要将 Program 中的 Add 改为 public static）
            int result = Program.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
