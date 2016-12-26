using System;
using CodingSamples.Services.RomanNumeralsToDecimal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.RomanNumeralsToDecimal
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Numerals_To_Decimal_Converter_Empty_String()
        {
            // Arrange
            var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

            //Act
            int result = numeralsToDecimalConverter.Convert("");
            
            //Assert
            Assert.Fail("Test should fail as empty string is an invalid parameter.");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Numerals_To_Decimal_Converter_NULL_String()
        {
            // Arrange
            var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

            //Act
            int result = numeralsToDecimalConverter.Convert(null);

            //Assert
            Assert.Fail("Test should fail as null is an invalid parameter.");
        }
    }

}
