using Xunit;
using SmallExtensions.Api.Extensions;
using System.Linq;

namespace SmallExtensions.Test.Units
{
    public class StringTest
    {
        [Theory]
        [InlineData("545644 ab", "545644")]
        [InlineData("!!!@@@@ 1214564", "1214564")]
        [InlineData("ASKDJHAKJSDHKJAHDKAD !1", "1")]
        public void TestStringExtensionOnlyNumber(string text, string expected)
        {
            Assert.Equal(expected, text.OnlyNumbers());
        }

        [Theory]
        [InlineData("545644 ab", "ab")]
        [InlineData("!!!@@@@ 1214564 bb", "bb")]
        [InlineData("ASKDJHAKJSDHKJAHDKAD !1", "ASKDJHAKJSDHKJAHDKAD")]
        public void TestStringExtensionOnlyAlphabet(string text, string expected)
        {
            Assert.Equal(expected, text.OnlyAlphabet());
        }

        [Theory]
        [InlineData("lowpoc", "Lowpoc")]
        [InlineData("developer c#", "Developer C#")]
        [InlineData("marcus vinicius Santana silva", "Marcus Vinicius Santana Silva")]
        public void TestStringExtensionCaptalize(string text, string expected)
        {
            Assert.Equal(expected, text.Captalize());
        }


        [Theory]
        [InlineData("l o w p o c ", "lowpoc")]
        [InlineData("de v e l o p e r c #", "developerc#")]
        [InlineData("marcus vinicius Santana silva", "marcusviniciusSantanasilva")]
        public void TestStringExtensionRemoveAllWhiteSpace(string text, string expected)
        {
            Assert.Equal(expected, text.RemoveAllWhiteSpaces());
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void TestStringExtensionIsNullOrEmpty(string text)
        {
            Assert.True(text.IsNullOrEmpty());
        }

        [Theory]
        [InlineData("Lowpoc Developer", "developer")]
        [InlineData("Test unit", "unit")]
        public void TestStringExtensionInWithoutCaseSensitive(string text, string search)
        {
            Assert.True(text.In(caseSensitive: false, search));
        }

        [Theory]
        [InlineData("Lowpoc Developer", "Developer ", true)]
        [InlineData("Test unit", "UNIT", false)]
        public void TestStringExtensionInWithCaseSensitive(string text, string search, bool expected)
        {
            var result = text.In(caseSensitive: true, search);

            if (expected)
            {
                Assert.True(result);
            }
            else
            {
                Assert.False(result);
            }
        }

        [Theory]
        [InlineData("Lowpoc Developer 12313", true)]
        [InlineData("Test unit @@@@!", false)]
        [InlineData("Test unit !!!!((())", false)]
        public void TestStringExtensionIsAlphaNumeric(string text, bool expected)
        {
            var result = text.IsAlphaNumeric();

            if (expected)
            {
                Assert.True(result);
            }
            else
            {
                Assert.False(result);
            }
        }

        [Theory]
        [InlineData("Lowpoc Developer", "repoleveD copwoL")]
        [InlineData("Test unit @@@@!", "!@@@@ tinu tseT")]
        [InlineData("Test unit !!!!((())", "))(((!!!! tinu tseT")]
        public void TestStringExtensionInvert(string text, string expected)
        {
            Assert.Equal(expected, text.Invert());
        }

        [Theory]
        [InlineData("ab", true)]
        [InlineData("bb", true)]
        [InlineData("ASKDJHAKJSDHKJAHDKAD123", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        public void TestStringExtensionIsAlphabet(string text, bool expected)
        {
            Assert.Equal(expected, text.IsAlphabet());
        }

        [Theory]
        [InlineData("ab", 10, "00000000ab")]
        [InlineData("bb", 5, "000bb")]
        [InlineData("ASKDJHAKJSDHKJAHDKAD123", 1, "ASKDJHAKJSDHKJAHDKAD123")]
        [InlineData("", 2, "00")]
        [InlineData(" ", 3, "00 ")]
        public void TestStringExtensionZeroFill(string text, int length, string expected)
        {
            Assert.Equal(expected, text.ZeroFill(length));
        }

        [Fact]
        public void TestStringExtensionFindWords()
        {
            var words = "Marcus Vinicius Santana Silva".FindWords(false, "us", "a");
            var ocurrencesOfus = words.Where(word => word.Value == "us").SingleOrDefault().Occurrences;
            var ocurrencesOfa = words.Where(word => word.Value == "a").SingleOrDefault().Occurrences;

            Assert.Contains(words.Where(word => word.Value == "us").Select(item => item.Locations).ToList(), locations => locations.Any(item => item.Start == 4 && item.End == 5));
            Assert.Contains(words.Where(word => word.Value == "us").Select(item => item.Locations).ToList(), locations => locations.Any(item => item.Start == 13 && item.End == 14));
            Assert.Equal(2, ocurrencesOfus);
            Assert.Equal(5, ocurrencesOfa);
        }
    }
}