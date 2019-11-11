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
    }
}