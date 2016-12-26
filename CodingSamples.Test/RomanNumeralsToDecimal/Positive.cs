using System.Collections.Generic;
using CodingSamples.Services.RomanNumeralsToDecimal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.RomanNumeralsToDecimal
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_Roman_Numerals_Conversion_64_To_Decimal()
        {
            // Arrange
            var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

            //Act
            int result = numeralsToDecimalConverter.Convert("LXIV");

            //Assert
            Assert.IsTrue(result == 64, $"Conversion failed, should have been 64, but is {result}");
        }

        [TestMethod]
        public void Test_Roman_Numerals_Conversion_226_To_Decimal()
        {
            // Arrange
            var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

            //Act
            int result = numeralsToDecimalConverter.Convert("CCXXVI");

            //Assert
            Assert.IsTrue(result == 226, $"Conversion failed, should have been 226, but is {result}");
        }
        [TestMethod]
        public void Test_Roman_Numerals_Conversion_3999_To_Decimal()
        {
            // Arrange
            var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

            //Act
            int result = numeralsToDecimalConverter.Convert("MMMCMXCIX");

            //Assert
            Assert.IsTrue(result == 3999, $"Conversion failed, should have been 3999, but is {result}");
        }
        [TestMethod]
        public void Test_Roman_Numerals_Conversion_4000_To_Decimal()
        {
            // Actually this is a trick: 3999 + 1 instead of 4000
            // as 3999 is the hightest number that can be represented with roman numerals

            // Arrange
            var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

            //Act
            int result = numeralsToDecimalConverter.Convert("MMMCMXCIXI");

            //Assert
            Assert.IsTrue(result == 4000, $"Conversion failed, should have been 4000, but is {result}");
        }

        [TestMethod]
        public void Test_Roman_Numerals_Conversion_Basic_Literals_M_D_C_L_X_V_I()
        {
            Dictionary<string, int> romanNumerals = new Dictionary<string, int>
            {
                {"M", 1000},
                {"D", 500},
                {"C", 100},
                {"L", 50},
                {"X", 10},
                {"V", 5},
                {"I", 1},
            };

            foreach (var romanNumeral in romanNumerals)
            {
                // Arrange
                var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

                //Act
                int result = numeralsToDecimalConverter.Convert(romanNumeral.Key);

                //Assert
                Assert.IsTrue(result == romanNumeral.Value, $"Conversion failed, should have been {romanNumeral.Value}, but is {result}");
            }
        }

        [TestMethod]
        public void Test_Roman_Numerals_Conversion_Basic_Valid_Combinations()
        {
            Dictionary<string, int> romanNumeralsValidCombinations = new Dictionary<string, int>
            {
                {"I", 1},
                {"II", 2},
                {"III", 3},
                {"IV", 4},
                {"V", 5},
                {"VI", 6},
                {"VII", 7},
                {"VIII", 8},
                {"IX", 9},
                {"X", 10},
                {"XX", 20},
                {"XXX", 30},
                {"XL", 40},
                {"L", 50},
                {"LX", 60},
                {"LXX", 70},
                {"LXXX", 80},
                {"XC", 90},
                {"C", 100},
                {"CC", 200},
                {"CCC", 300},
                {"CD", 400},
                {"D", 500},
                {"DC", 600},
                {"DCC", 700},
                {"DCCC", 800},
                {"CM", 900},
                {"M", 1000},
                {"MM", 2000},
                {"MMM", 3000},
            };

            foreach (var romanNumeral in romanNumeralsValidCombinations)
            {
                //arrange
                var numeralsToDecimalConverter = new RomanNumeralsToDecimalConverter();

                //Act
                int result = numeralsToDecimalConverter.Convert(romanNumeral.Key);

                //Assert
                Assert.IsTrue(result == romanNumeral.Value, $"Conversion failed, should have been {romanNumeral.Value}, but is {result}");
            }
            
        }
    }
}
