using System;
using Xunit;

namespace CalculatorWithTests.Test
{
    public class UnitTest1
    {
       
        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(10, 4, 14)]
        [InlineData(15, 15, 30)]
        [InlineData(4, 21, 25)]
        [InlineData(3, 12, 15)]

        public void Sum(decimal x, decimal y, decimal expected)
        {
            //Arrange
            CalculatorWithTests calculator = new CalculatorWithTests();

            //Act
            decimal actual = calculator.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData( 2, 5, 3)]
        [InlineData(10, 4, 6)]
        [InlineData(15, 15, 0)]
        [InlineData(4, 21, -17)]
        [InlineData(new double[] { 3, 12 }, -9)]

        public void Difference(decimal x, decimal y, decimal expected)
        {
            //Arrange
            CalculatorWithTests calculator = new CalculatorWithTests();

            //Act
            decimal actual = calculator.Subtract(x, y);

            //Assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(new double[] { 2, 5 }, 10)]
        [InlineData(new double[] { 10, 4 }, 40)]
        [InlineData(new double[] { 15, 15 }, 225)]
        [InlineData(new double[] { 4, 21 }, 84)]
        [InlineData(new double[] { 3, 12 }, 36)]

        public void Product(decimal x, decimal y, decimal expected)
        {
            //Arrange
            CalculatorWithTests calculator = new CalculatorWithTests();

            //Act
            decimal actual = calculator.Multipy(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 5, .4)]
        [InlineData(10, 4, 2.5)]
        [InlineData(15, 15, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(3, 1, 1)]

        public void Quotient(decimal x, decimal y, decimal expected)
        {
            //Arrange
            CalculatorWithTests calculator = new CalculatorWithTests();

            //Act
            decimal actual = calculator.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]

        public void FactorialProduct(decimal x, decimal expected)
        {
            //Arrange
            CalculatorWithTests calculator = new CalculatorWithTests();

            //Act
            decimal actual = calculator.Factorial(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
