namespace SmallExtensions.API.Extensions
{
    /// <summary>
    /// The main class for extensions of type decimal.
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// Rounds a decimal value to the specified number of fractional digits and uses the specified rounding convention for the midpoint values.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static decimal RoundTo(this decimal value, int decimals) => decimal.Round(value, decimals);

        /// <summary>
        /// The method returns what is the value of a given percentage.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="percent"></param>
        /// <returns></returns>
        public static decimal Percent(this decimal value, decimal percent) => (value * percent) / 100;

        /// <summary>
        /// The method returns which is the percentage of a value with the total value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static decimal PercentOf(this decimal value, decimal total) => (total == 0) ? 0 : (value / total) * 100;

        /// <summary>
        /// Convert value positive for negative.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Negative(this decimal value) => value < 0 ? value : value * -1;

        /// <summary>
        ///  Convert value negative for positive.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Positive(this decimal value) => value > 0 ? value : value * -1;

        /// <summary>
        /// The method verify if the value is negative.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNegative(this decimal value) => value < 0;

        /// <summary>
        /// The method verify if the value is positive (>=0).
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPositive(this decimal value) => value >= 0;
    }
}