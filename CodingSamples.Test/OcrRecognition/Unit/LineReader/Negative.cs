using System;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CodingSamples.Test.OcrRecognition.Unit.LineReader
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Test_Shall_Raise_Argument_Null_Exception_On_Null_Parameter()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.LineReader));
            var fileReaderSubstitute = Substitute.For<IFileReader>();
            var lineReader = new Services.OcrRecognition.LineReader(log, fileReaderSubstitute);

            //Act
            var result = lineReader.Read(null);

            //Assert
            Assert.Fail("Test should fail on null parameter.");
        }
    }
}