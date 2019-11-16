using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using api.enums;

namespace api.extensions
{
    /// <summary>
    /// The main class for extensions of type string.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        ///  Verify if string is null or empty.
        /// </summary>
        public static bool IsNullOrEmpty(this string text) => string.IsNullOrEmpty(text);

        /// <summary>
        ///  Verify if string is null or whitespace.
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string text) => string.IsNullOrWhiteSpace(text);

        /// <summary>
        ///  Verify if string is alphanumeric with regex <see cref="RuleRegex.Aplhanumeric" />.
        /// </summary>
        public static bool IsAlphaNumeric(this string text) => Regex.IsMatch(text, RuleRegex.Aplhanumeric);


        /// <summary>
        ///  Remove all caracteres except numbers with regex <see cref="RuleRegex.OnlyNumber" />.
        /// </summary>
        public static string OnlyNumbers(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            return Regex.Replace(text, RuleRegex.OnlyNumber, string.Empty);
        }

        /// <summary>
        ///  Remove all caracteres except alphabet with regex <see cref="RuleRegex.OnlyAlphabet" />.
        /// </summary>
        public static string OnlyAlphabet(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            return Regex.Replace(text, RuleRegex.OnlyAlphabet, string.Empty);
        }

        /// <summary>
        /// Method converts the first character of a string to capital (uppercase) letter. If the string has its first character as capital, then it returns the original string.
        /// </summary>
        public static string Captalize(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(text);
        }

        /// <summary>
        ///  Remove all white spaces. 
        /// </summary>
        public static string RemoveAllWhiteSpaces(this string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            return text.Replace(RuleRegex.WhiteSpace, string.Empty);
        }


        /// <summary>
        /// Method check if exist a word with case sensitive or no. 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="values"></param>
        /// <returns>bool</returns>
        public static bool In(this string text, bool caseSensitive, params string[] values)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            var list = values.Select(value => caseSensitive ? value.Trim() : value.ToLower().Trim()).ToList();
            var str = caseSensitive ? text.Trim() : text.ToLower().Trim();

            return list.Any(value => str.Contains(value));
        }

        /// <summary>
        ///  Invert a string. 
        /// <example>
        /// <code>
        /// string text = "asbcd 123";
        /// text.Invert(); // 321 dcbsa
        /// </code>
        /// </example>
        /// </summary>
        public static string Invert(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            var reverseText = new String(text.Reverse().ToArray());
            return reverseText;
        }

        /// <summary>
        ///  Verify if string is only alphabet with regex <see cref="RuleRegex.OnlyAlphabet" /> 
        /// </summary>
        public static bool IsAlphabet(this string text)
        {
            if (text.IsNullOrWhiteSpace()) return false;

            return !Regex.IsMatch(text, RuleRegex.OnlyAlphabet);
        }

        /// <summary>
        /// The method adds zeros (0) at the beginning of the string, until it reaches the specified length
        /// </summary>
        public static string ZeroFill(this string text, int length)
        {
            if (text == null) return text;

            var count = length - text.Count();

            for (int i = 0; i < count; i++)
            {
                text = text.Insert(0, "0");
            }

            return text;
        }
    }
}