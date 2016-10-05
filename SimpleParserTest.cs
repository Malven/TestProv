using System;
using Xunit;
using Prov2015;

namespace Prov2015Test
{
    public class SimpleParserTest
    {
        [Fact]
        public void ParseAndSum_EmptyString_ReturnsZero()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            int sum = sp.ParseAndSum("");

            //Assert
            Assert.Equal(0, sum);
        }
        [Fact]
        public void ParseAndSum_TwoValues_ReturnsSum()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            int sum = sp.ParseAndSum("10,2");

            //Assert
            Assert.Equal(12, sum);
        }
        [Fact]
        //https://www.richard-banks.org/2015/07/stop-using-assertthrows-in-your-bdd.html
        public async void ParseAndSum_InvalidSeparator_InvalidOperationException()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            int i;
            var exception = await Record.ExceptionAsync(() => i = sp.ParseAndSum("10:2"));

            //Assert
            Assert.NotNull(exception);
            Assert.IsType<InvalidOperationException>(exception);

        }

        [Fact]
        public void ParseAndSplit_String_ReturnsArrayofStrings()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            string[] listofstrings = sp.ParseAndSplit("1,20,300");

            //Assert
            string[] expected = new string[] { "1", "20", "300" };
            Assert.Equal(expected, listofstrings);
        }
    }
}
