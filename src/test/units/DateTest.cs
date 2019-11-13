using System;
using Xunit;
using api.extensions;

namespace test.units
{
    public class DateTest
    {
        [Fact]
        public void TestDateYesterday()
        {
            Assert.Equal(DateTime.Now.AddDays(-1).Date, DateTime.Now.Yesterday().Date);
        }

        [Theory]
        [InlineData("dd-MM-yy")]
        [InlineData("dd/MM/yyyy")]
        [InlineData("dddd, MMMM dd")]
        [InlineData("M/yy")]
        [InlineData("dddd, MMMM dd yyyy")]
        public void TestDateFormat(string format)
        {
            Assert.IsType<string>(DateTime.Now.Format(format));
        }

        [Fact]
        public void TestDateLastDayOfTheMonth()
        {
            Assert.Equal(new DateTime(2019,11,30).Date, new DateTime(2019, 11, 11).LastDayOfTheMonth().Date);
            Assert.Equal(new DateTime(2019, 12, 31).Date, new DateTime(2019, 12, 16).LastDayOfTheMonth().Date);
            Assert.Equal(new DateTime(2020, 1, 31).Date, new DateTime(2020, 1, 05).LastDayOfTheMonth().Date);
        }

        [Fact]
        public void TestInTheSameMonthCurrent()
        {
            Assert.False(new DateTime(2019,10,13).InTheSameMonthCurrent());
        }
    }
}