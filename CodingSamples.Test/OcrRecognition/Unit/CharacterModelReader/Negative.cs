using System;
using CodingSamples.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.CharacterModelReader
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Test_Shall_Raise_Exception_On_Null_Argument()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.CharacterModelReader));
            var characterModelReader = new Services.OcrRecognition.CharacterModelReader(log);

            //Act
            var result = characterModelReader.Read(null);

            //Assert
            Assert.Fail("Method should raise ArgumentNullException on null argument.");
        }
    }
}