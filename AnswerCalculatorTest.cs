using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prov2015Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddNumbersReturnSum()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            double sum = calc.Add(10.0, 10.0);

            //Assert
            Assert.AreEqual(20.0, sum, 0.01);  //3:e parameter är Deltavärde då man inte kan jämföra för exakt lika med noll med flyttal. 
        }
        [TestMethod]
        public void MultiplyNumbersReturnSum()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            double sum = calc.Mul(10.0, 10.0);

            //Assert
            Assert.AreEqual(100.0, sum, 0.01);
        }
        //Skriv test och kod för följande funktionalitet som jobbar med double flyttal
        //1. Dividera två tal med varandra.
        [TestMethod]
        public void DivideNumbersReturnSum()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            double sum = calc.Div(10.0, 2.0);

            //Assert
            Assert.AreEqual(5.0, sum, 0.01);
        }
        //2. Hantera division by zero genom att kontrollera att inte täljaren är 0. Om så är fallet kasta en exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Can't divide by zero")]
        public void TryDivideByZeroCastsException()
        { 
            //Arrange
            Calculator calc = new Calculator();

            //Act
            double sum = calc.Div(10.0, 0.0);
        }
        //3. Summan av en array av tal ska returneras.
        [TestMethod]
        public void AddArrayOfNumbersReturnSum()
        {
            //Arrange
            Calculator calc = new Calculator();
            double[] numbers = new double[5] { 1, 2, 3, 4, 5 };
            //Act
            double sum = calc.Add(numbers);

            //Assert
            Assert.AreEqual(15.0, sum, 0.01);
        }
        //4. En funktion som returnerar true för tal som är 0 eller positiva. false för tal som är negativa.
        [TestMethod]
        public void TestNumIsPositiveReturnsTrue()
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            bool answer = calc.IsPositive(0.0);

            //Assert
            Assert.AreEqual(true, answer);
        }
        [TestMethod]
        public void TestNumIsNegativeReturnsFalse()
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            bool answer = calc.IsPositive(-1.0);

            //Assert
            Assert.AreEqual(false, answer);
        }
        //En kalkulator som tar string som input kan vara användbart ibland. Följande krav tar string som input och returnerar double.
        //1.An empty string returns zero
        [TestMethod]
        public void EmptyStringReturnsSumZero()
        {
            //Arrange
            Calculator calc = new Calculator();
            string input = "";
            //Act
            double answer = calc.Sum(input);

            //Assert
            Assert.AreEqual(0.0, answer,0.0001);
        }
        //2.A single number returns the value
        [TestMethod]
        public void SingleValueStringReturnsValue()
        {
            //Arrange
            Calculator calc = new Calculator();
            string input = "10";
            //Act
            double answer = calc.Sum(input);

            //Assert
            Assert.AreEqual(10.0, answer, 0.0001);
        }
        //3.Two numbers, comma delimited, returns the sum
        [TestMethod]
        public void TwoValuesCommaStringReturnsSum()
        {
            //Arrange
            Calculator calc = new Calculator();
            string input = "10,20";
            //Act
            double answer = calc.Sum(input);

            //Assert
            Assert.AreEqual(30.0, answer, 0.0001);
        }
        //4.Two numbers, newline delimited, returns the sum
        [TestMethod]
        public void TwoValuesWithNewLineStringReturnsSum()
        {
            //Arrange
            Calculator calc = new Calculator();
            string input = "10\n20";
            //Act
            double answer = calc.Sum(input);

            //Assert
            Assert.AreEqual(30.0, answer, 0.0001);
        }
        //5.Three numbers, delimited either way, returns the sum
        [TestMethod]
        public void ThreeValuesWithNewLineStringReturnsSum()
        {
            //Arrange
            Calculator calc = new Calculator();
            string input = "10\n20,30";
            //Act
            double answer = calc.Sum(input);

            //Assert
            Assert.AreEqual(60.0, answer, 0.0001);
        }
        //6.Negative numbers throw an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Negative values not allowed")]
        public void NegativeNumbersCastsException()
        {
            //Arrange
            Calculator calc = new Calculator();

            string input = "10\n-20,30";
            //Act
            double answer = calc.Sum(input);
        }
        //7.Numbers greater than 1000 are ignored
        [TestMethod]
        public void IgnoreValuesGreaterThan1000ReturnsSum()
        {
            //Arrange
            Calculator calc = new Calculator();
            string input = "10,20,\n30,1000,1001";
            //Act
            double answer = calc.Sum(input);

            //Assert
            Assert.AreEqual(1060.0, answer, 0.0001);
        }







    }
}
