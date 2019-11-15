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
        public static bool IsNullOrEmpty(this string text) => string.IsNullOrEmpty(text);
        public static bool IsNullOrWhiteSpace(this string text) => string.IsNullOrWhiteSpace(text);
        public static bool IsAlphaNumeric(this string text) => Regex.IsMatch(text, RuleRegex.Aplhanumeric);

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

        public static bool In(this string text, bool caseSensitive, params string[] values)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            var list = values.Select(value => caseSensitive ? value.Trim() : value.ToLower().Trim()).ToList();
            var str = caseSensitive ? text.Trim() : text.ToLower().Trim();

            return list.Any(value => str.Contains(value));
        }

        public static string Invert(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            var reverseText = new String(text.Reverse().ToArray());
            return reverseText;
        }

        public static bool IsAlphabet(this string text)
        {
            if (text.IsNullOrWhiteSpace()) return false;

            return !Regex.IsMatch(text, RuleRegex.OnlyAlphabet);
        }

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