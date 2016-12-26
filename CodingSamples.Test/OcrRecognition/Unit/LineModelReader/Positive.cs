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
            const string LINE_1 = "     _   _       _   _   _   _   _   _ ";
            const string LINE_2 = "  |  _|  _| |_| |_  |_    | |_| |_| | |";
            const string LINE_3 = "  | |_   _|   |  _| |_|   | |_|  _| |_|";

            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.LineModelReader));
            var lines = new List<string>
            {
                LINE_1,
                LINE_2,
                LINE_3
            };
            var lineReader = new Services.OcrRecognition.LineModelReader(log);

            //Act
            var result = lineReader.Read(lines);

            //Assert
            Assert.IsTrue(result.Count() == 1, $"Should have returned 1 line but returned {result.Count()}.");
            var item = result.ToList()[0];
            Assert.IsTrue(item.Line1 == LINE_1, $"Should have returned {LINE_1} as line 1 but returned {item.Line1}.");
            Assert.IsTrue(item.Line2 == LINE_2, $"Should have returned {LINE_2} as line 2 but returned {item.Line2}.");
            Assert.IsTrue(item.Line3 == LINE_3, $"Should have returned {LINE_3} as line 3 but returned {item.Line3}.");
        }
    }
}