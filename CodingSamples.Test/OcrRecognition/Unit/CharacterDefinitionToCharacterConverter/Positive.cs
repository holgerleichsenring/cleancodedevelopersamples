using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.CharacterDefinitionToCharacterConverter
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_Conversion_Of_Number_One_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "1";
            string characterToCheck = characterDefinitions.Character1;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Two_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "2";
            string characterToCheck = characterDefinitions.Character2;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Three_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "3";
            string characterToCheck = characterDefinitions.Character3;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Four_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "4";
            string characterToCheck = characterDefinitions.Character4;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Five_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "5";
            string characterToCheck = characterDefinitions.Character5;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Six_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "6";
            string characterToCheck = characterDefinitions.Character6;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Seven_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "7";
            string characterToCheck = characterDefinitions.Character7;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Eight_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "8";
            string characterToCheck = characterDefinitions.Character8;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Nine_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "9";
            string characterToCheck = characterDefinitions.Character9;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_Number_Zero_String_To_Number()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterDefinitionToCharacterConverter));
            var characterDefinitions = new CharacterDefinitions();
            var characterDefinitionToCharacterConverter = new Services.OcrRecognition.CharacterDefinitionToCharacterConverter(log, characterDefinitions);
            const string EXPECTED_NUMBER = "0";
            string characterToCheck = characterDefinitions.Character0;

            //Act
            var result = characterDefinitionToCharacterConverter.Convert(characterToCheck);

            //Assert
            Assert.IsTrue(result == EXPECTED_NUMBER, $"Converter should have returned {EXPECTED_NUMBER} but returned {result}.");
        }
    }
}