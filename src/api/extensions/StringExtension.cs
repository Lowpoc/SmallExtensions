using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using api.enums;

namespace api.extensions
{
    public static class StringExtension
    {
        public static string OnlyNumbers(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            return Regex.Replace(text, RuleRegex.OnlyNumber, string.Empty);
        }

        public static string OnlyAlphabet(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            return Regex.Replace(text, RuleRegex.OnlyAlphabet, string.Empty);
        }

        public static string Captalize(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(text);
        }

        public static string RemoveAllWhiteSpaces(this string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            return text.Replace(RuleRegex.WhiteSpace, string.Empty);
        }

        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }

        public static bool IsNullOrWhiteSpace(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static bool In(this string text, bool caseSensitive, params string[] values)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            var list = values.Select(value => caseSensitive ? value.Trim() : value.ToLower().Trim()).ToList();
            var str = caseSensitive ? text.Trim() : text.ToLower().Trim();

            return list.Any(value => str.Contains(value));
        }

        public static bool IsAlphaNumeric(this string text)
        {
            return Regex.IsMatch(text, RuleRegex.Aplhanumeric);
        }
    }
}