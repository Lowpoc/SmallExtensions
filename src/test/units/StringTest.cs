using Xunit;
using api.extensions;

namespace test.units
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
    }
}