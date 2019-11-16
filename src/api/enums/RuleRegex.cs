namespace api.enums
{
    /// <summary>
    /// The main class for regex.
    /// </summary>
    public class RuleRegex
    {
        /// <summary>
        ///  Regex valid  for only numbers.
        /// </summary>
        public const string OnlyNumber = "[^\\d]+";

        /// <summary>
        ///  Regex valid  for only alphabet.
        /// </summary>
        public const string OnlyAlphabet = "[^A-Za-z]+";

        /// <summary>
        ///  Regex valid  for only whitespace.
        /// </summary>
        public const string WhiteSpace = " ";

        /// <summary>
        ///  Regex valid  for only aplhanumeric.
        /// </summary>
        public const string Aplhanumeric = "[\\w]+$";
    }
}