using System;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.CharacterDefinitionToCharacterConverter
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void Test_Shall_Raise_Exception_On_Null_Argument()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(null);

            //Assert
            Assert.Fail("Method should raise ArgumentNullException on null argument.");
        }
    }
}