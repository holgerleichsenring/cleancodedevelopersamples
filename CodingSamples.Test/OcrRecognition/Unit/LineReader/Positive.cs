using System.Collections.Generic;
using System.IO;
using System.Text;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CodingSamples.Test.OcrRecognition.Unit.LineReader
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_Calls_Open_File_And_Returns_Iterated_Stream()
        {
            // Arrange
            const string TEST_FILE_NAME = "TESTFILE.TXT";
            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.LineReader));
            var fileReaderSubstitute = Substitute.For<IFileReader>();

            var lines = new List<string>
            {
                "     _   _       _   _   _   _   _   _ ",
                "  |  _|  _| |_| |_  |_    | |_| |_| | |",
                "  | |_   _|   |  _| |_|   | |_|  _| |_|"
            };
            string stringLines = string.Join("\n", lines);
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringLines));
            var streamReader = new StreamReader(memoryStream);
            fileReaderSubstitute
                .OpenText(TEST_FILE_NAME)
                .ReturnsForAnyArgs(streamReader);

            var lineReader = new Services.OcrRecognition.LineReader(log, fileReaderSubstitute);

            //Act
            var result = lineReader.Read(TEST_FILE_NAME);

            //Assert
            fileReaderSubstitute.Received().OpenText(TEST_FILE_NAME);
            Assert.IsTrue(lines.ToString() == result.ToString(), "Line Reader does not return expected lines.");
        }
    }
}