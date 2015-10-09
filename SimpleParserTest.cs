using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prov2015;

namespace Prov2015Test
{
    [TestClass]
    public class SimpleParserTest
    {
        [TestMethod]
        public void ParseAndSum_EmptyString_ReturnsZero()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            int sum = sp.ParseAndSum("");

            //Assert
            Assert.AreEqual(0, sum);
        }
        [TestMethod]
        public void ParseAndSum_TwoValues_ReturnsSum()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            int sum = sp.ParseAndSum("10,2");

            //Assert
            Assert.AreEqual(12, sum);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ParseAndSum_InvalidSeparator_InvalidOperationException()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            int sum = sp.ParseAndSum("10:2");
        }
        [TestMethod]
        public void ParseAndSplit_String_ReturnsArrayofStrings()
        {
            //Arrange
            SimpleParser sp = new SimpleParser();

            //Act
            string[] listofstrings = sp.ParseAndSplit("1,20,300");

            //Assert
            string[] expected = new string[] { "1", "20", "300" };
            CollectionAssert.AreEqual(expected, listofstrings);
        }
    }
}
