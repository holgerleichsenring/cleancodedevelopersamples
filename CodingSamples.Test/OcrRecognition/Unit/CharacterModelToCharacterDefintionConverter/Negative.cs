using System;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.CharacterModelToCharacterDefintionConverter
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Test_Shall_Raise_Exception_On_Null_Argument()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.CharacterModelToCharacterDefinitionConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterModelToCharacterDefinitionConverter = new Services.OcrRecognition.CharacterModelToCharacterDefinitionConverter(log);

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(null);

            //Assert
            Assert.Fail("Method should raise ArgumentNullException on null argument.");
        }
    }
}