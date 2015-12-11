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
            Assert.AreEqual(20.0, sum, 0.01);
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
        //2. Hantera division by zero genom att kontrollera att inte täljaren är 0. Om så är fallet kasta en exception
        //3. Summan av en array av tal ska returneras.
        //4. En funktion som returnerar true för tal som är 0 eller positiva. false för tal som är negativa.

        //En kalkulator som tar string som input kan vara användbart ibland. Följande krav tar string som input och returnerar double.
        //1.An empty string returns zero
        //2.A single number returns the value
        //3.Two numbers, comma delimited, returns the sum
        //4.Two numbers, newline delimited, returns the sum
        //5.Three numbers, delimited either way, returns the sum
        //6.Negative numbers throw an exception
        //7.Numbers greater than 1000 are ignored







    }
}
