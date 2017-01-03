using System.Collections.Generic;
using System.Linq;
using CodingSamples.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.LineModelReader
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_Line_Transformation_Should_Encapsulate_Three_Lines_In_One()
        {
            // Arrange
            const string TEST_FILE_NAME = "TESTFILE.TXT";

            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.LineModelReader));
            var lines = new List<string>
            {
                CharacterConstants.NUMBERS_1234567890_LINE_1,
                CharacterConstants.NUMBERS_1234567890_LINE_2,
                CharacterConstants.NUMBERS_1234567890_LINE_3
            };
            var lineReader = new Services.OcrRecognition.LineModelReader(log);

            //Act
            var result = lineReader.Read(lines);

            //Assert
            Assert.IsTrue(result.Count() == 1, $"Should have returned 1 line but returned {result.Count()}.");
            var item = result.ToList()[0];
            Assert.IsTrue(item.Line1 == CharacterConstants.NUMBERS_1234567890_LINE_1, $"Should have returned {CharacterConstants.NUMBERS_1234567890_LINE_1} as line 1 but returned {item.Line1}.");
            Assert.IsTrue(item.Line2 == CharacterConstants.NUMBERS_1234567890_LINE_2, $"Should have returned {CharacterConstants.NUMBERS_1234567890_LINE_2} as line 2 but returned {item.Line2}.");
            Assert.IsTrue(item.Line3 == CharacterConstants.NUMBERS_1234567890_LINE_3, $"Should have returned {CharacterConstants.NUMBERS_1234567890_LINE_3} as line 3 but returned {item.Line3}.");
        }
    }
}