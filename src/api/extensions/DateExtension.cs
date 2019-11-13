using System;

namespace api.extensions
{
    public static class DateExtension
    {
        public static DateTime Yesterday(this DateTime date) => date.AddDays(-1);
        public static string Format(this DateTime date, string format = "dd/MM/yyyy") => date.ToString(format);
        public static DateTime LastDayOfTheMonth(this DateTime date) => new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        public static bool InTheSameMonthCurrent(this DateTime date) => date.Month == DateTime.Now.Month;
        public static bool InTheLastMonth(this DateTime date) => date.Month == DateTime.Now.AddMonths(-1).Month;

        public static bool InTheSameWeekCurrent(this DateTime date)
        {
            var today = DateTime.Now;
            var calendar = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;

            return date.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(date)) == today.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(today));
        }

        public static bool AreInTheLastSemester(this DateTime date)
        {
            var today = DateTime.Now;

            if (today.Month <= 6 && today.Month >= 1 && date.Month <= 6 && date.Month >= 1)
                return true;

            if (today.Month <= 12 && today.Month > 6 && date.Month <= 12 && date.Month > 6)
                return true;

            return false;
        }

        public static bool AreInTheLastYear(this DateTime date)
        {
            var today = DateTime.Now;

            if (today.Year == date.Year)
                return true;

            return false;
        }
    }
}