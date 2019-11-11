using System;
using System.Text.RegularExpressions;
using api.enums;

namespace api.extensions
{
    public static class StringExtension
    {
        public static string OnlyNumbers(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            return  Regex.Replace(text, RuleRegex.OnlyNumber, string.Empty);
        }
    }
}