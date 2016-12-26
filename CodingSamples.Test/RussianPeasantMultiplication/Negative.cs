using System;
using CodingSamples.RussianPeasantMultiplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.RussianPeasantMultiplication
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Invalid_Factor_0()
        {
            // Arrange
            var russianPeasantMultiplicationCalculator = new RussianPeasantMultiplicationCalculator();

            //Act
            int result = russianPeasantMultiplicationCalculator.Mul(0, 99);
            
            //Assert
            Assert.Fail("Test should fail as x = 0 is an invalid parameter.");
        }
    }

}
