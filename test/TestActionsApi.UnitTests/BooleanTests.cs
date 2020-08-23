using Xunit;

namespace TestActionsApi.UnitTests
{
    public class BooleanTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void FalseIsFalse()
        {
            Assert.False(false);
        }
    }
}