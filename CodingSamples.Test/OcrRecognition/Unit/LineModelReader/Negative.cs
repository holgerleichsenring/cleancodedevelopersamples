using System;
using System.IO;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CodingSamples.Test.OcrRecognition.Unit.LineModelReader
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Test_Shall_Raise_Exception_On_Null_Argument()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.LineModelReader));
            var lineModelReader = new Services.OcrRecognition.LineModelReader(log);

            //Act
            var result = lineModelReader.Read(null);

            //Assert
            Assert.Fail("Method should raise ArgumentNullException on null argument.");
        }
    }
}