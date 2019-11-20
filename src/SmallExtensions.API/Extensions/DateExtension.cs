using System;

namespace SmallExtensions.Api.Extensions
{
    /// <summary>
    ///  The main class for extensions of type date.
    /// </summary>
    public static class DateExtension
    {
        /// <summary>
        /// Method return the yesterday.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime Yesterday(this DateTime date) => date.AddDays(-1);

        /// <summary>
        /// Method to format dates in different formats.
        /// The following table describes various date time formats and their results. Here we see all the patterns of the DateTime Class.
        /// MM/dd/yyyy
        /// dddd, dd MMMM yyyy
        /// dddd, dd MMMM yyyy HH:mm:ss".
        /// Link for see others formats: https://docs.microsoft.com/pt-br/dotnet/api/system.datetime.tostring?view=netframework-4.8
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string Format(this DateTime date, string format = "dd/MM/yyyy") => date.ToString(format);

        /// <summary>
        /// Method return the last day of month.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime LastDayOfTheMonth(this DateTime date) => new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

        /// <summary>
        /// Check if a date belongs in the month current.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool InTheSameMonthCurrent(this DateTime date) => date.Month == DateTime.Now.Month;

        /// <summary>
        /// Check if a date belongs in the last month.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool InTheLastMonth(this DateTime date) => date.Month == DateTime.Now.AddMonths(-1).Month;

        /// <summary>
        /// The method add Weeks.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfWeeks"></param>
        /// <returns></returns>
        public static DateTime AddWeeks(this DateTime dateTime, int numberOfWeeks) => dateTime.AddDays(numberOfWeeks * 7);

        /// <summary>
        /// The method add Fortnights.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfFortnights"></param>
        /// <returns></returns>
        public static DateTime AddFortnights(this DateTime dateTime, int numberOfFortnights) => dateTime.AddDays(numberOfFortnights * 15);

        /// <summary>
        /// The method add Bimesters.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfBimesters"></param>
        /// <returns></returns>
        public static DateTime AddBimesters(this DateTime dateTime, int numberOfBimesters) => dateTime.AddMonths(numberOfBimesters * 2);

        /// <summary>
        /// The method  add Quarters.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfQuarters"></param>
        /// <returns></returns>
        public static DateTime AddQuarters(this DateTime dateTime, int numberOfQuarters) => dateTime.AddMonths(numberOfQuarters * 3);

        /// <summary>
        /// The method  add HalfYears.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="numberOfHalfYears"></param>
        /// <returns></returns>
        public static DateTime AddHalfYears(this DateTime dateTime, int numberOfHalfYears) => dateTime.AddMonths(numberOfHalfYears * 6);

        /// <summary>
        /// Check if a date belongs the week current.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool InTheSameWeekCurrent(this DateTime date)
        {
            var today = DateTime.Now;
            var calendar = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;

            return date.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(date)) == today.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(today));
        }

        /// <summary>
        /// Check if a date belongs the last semester.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool AreInTheLastSemester(this DateTime date)
        {
            var today = DateTime.Now;

            if (today.Month <= 6 && today.Month >= 1 && date.Month <= 6 && date.Month >= 1)
                return true;

            if (today.Month <= 12 && today.Month > 6 && date.Month <= 12 && date.Month > 6)
                return true;

            return false;
        }

        /// <summary>
        /// Check if a date belongs the last year.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool AreInTheLastYear(this DateTime date)
        {
            var today = DateTime.Now;

            if (today.Year == date.Year)
                return true;

            return false;
        }
    }
}