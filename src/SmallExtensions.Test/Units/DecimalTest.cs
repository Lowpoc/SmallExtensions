using Xunit;
using SmallExtensions.API.Extensions;

namespace SmallExtensions.Test.Units
{
    public class DecimalTest
    {
        [Fact]
        public void TestToPositive()
        {
            decimal amount = -10M;
            Assert.Equal(10M, amount.Positive());
        }

        [Fact]
        public void TestToNegative()
        {
            decimal amount = 10M;
            Assert.Equal(-10M, amount.Negative());
        }

        [Fact]
        public void TestIsNegative()
        {
            decimal amount = -10M;
            Assert.True(amount.IsNegative());
            Assert.False(amount.Positive().IsNegative());
        }

        [Fact]
        public void TestIsPositive()
        {
            decimal amount = 10M;
            Assert.True(amount.IsPositive());
            Assert.False(amount.Negative().IsPositive());
        }

        [Fact]
        public void TestPercent()
        {
            decimal amount = 10M;
            Assert.Equal(5, amount.Percent(50));
        }

        [Fact]
        public void TestPercentOf()
        {
            decimal amount = 10M;
            decimal total = 100M;

            Assert.Equal(10, amount.PercentOf(total));
        }
    }
}