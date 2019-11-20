using System;
using Xunit;
using SmallExtensions.Api.Extensions;

namespace SmallExtensions.Test.Units
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
            Assert.Equal(new DateTime(2019, 11, 30).Date, new DateTime(2019, 11, 11).LastDayOfTheMonth().Date);
            Assert.Equal(new DateTime(2019, 12, 31).Date, new DateTime(2019, 12, 16).LastDayOfTheMonth().Date);
            Assert.Equal(new DateTime(2020, 1, 31).Date, new DateTime(2020, 1, 05).LastDayOfTheMonth().Date);
        }

        [Fact]
        public void TestInTheSameMonthCurrent()
        {
            Assert.False(new DateTime(2019, 10, 13).InTheSameMonthCurrent());
        }

        [Fact]
        public void TestAddWeeks()
        {
            var day = new DateTime(2019, 11, 20);
            Assert.Equal(day.AddDays(14).Date, day.AddWeeks(2).Date);
        }

        [Fact]
        public void TestAddAddFortnights()
        {
            var day = new DateTime(2019, 11, 20);
            Assert.Equal(day.AddDays(30).Date, day.AddFortnights(2).Date);
        }

        [Fact]
        public void TestAddBimesters()
        {
            var day = new DateTime(2019, 11, 20);
            Assert.Equal(day.AddMonths(4).Date, day.AddBimesters(2).Date);
        }

        [Fact]
        public void TestAddHalfYears()
        {
            var day = new DateTime(2019, 11, 20);
            Assert.Equal(day.AddMonths(12).Date, day.AddHalfYears(2).Date);
        }
    }
}