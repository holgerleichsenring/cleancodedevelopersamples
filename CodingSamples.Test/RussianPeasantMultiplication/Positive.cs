using CodingSamples.RussianPeasantMultiplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.RussianPeasantMultiplication
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_47_x_42_Shall_Have_Result_1972()
        {
            // Arrange
            var russianPeasantCalculator = new RussianPeasantMultiplicationCalculator();

            //Act
            int result = russianPeasantCalculator.Mul(47, 42);

            //Assert
            int comparison = 47 * 42;
            Assert.IsTrue(result == comparison, $"Multiplication failed, should have been {comparison}, but is {result}");
        }

        [TestMethod]
        public void Test_1_x_100_Shall_Have_Result_100()
        {
            // Arrange
            var russianPeasantCalculator = new RussianPeasantMultiplicationCalculator();

            //Act
            int result = russianPeasantCalculator.Mul(1, 100);

            //Assert
            int comparison = 1 * 100;
            Assert.IsTrue(result == comparison, $"Multiplication failed, should have been {comparison}, but is {result}");
        }

        [TestMethod]
        public void Test_2_x_100_Shall_Have_Result_200()
        {
            // Arrange
            var russianPeasantCalculator = new RussianPeasantMultiplicationCalculator();

            //Act
            int result = russianPeasantCalculator.Mul(2, 100);

            //Assert
            int comparison = 2 * 100;
            Assert.IsTrue(result == comparison, $"Multiplication failed, should have been {comparison}, but is {result}");
        }

        [TestMethod]
        public void Test_99_x_99_Shall_Have_Result_9801()
        {
            // Arrange
            var russianPeasantCalculator = new RussianPeasantMultiplicationCalculator();

            //Act
            int result = russianPeasantCalculator.Mul(99, 99);

            //Assert
            int comparison = 99 * 99;
            Assert.IsTrue(result == comparison, $"Multiplication failed, should have been {comparison}, but is {result}");
        }
    }
}