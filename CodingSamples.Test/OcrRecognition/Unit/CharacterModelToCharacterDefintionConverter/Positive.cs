using System.Collections.Generic;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition;
using CodingSamples.Services.OcrRecognition.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.CharacterModelToCharacterDefintionConverter
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_One_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof (CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character1;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_1_LINE_1,
                Line2 = CharacterConstants.CHARACTER_1_LINE_2,
                Line3 = CharacterConstants.CHARACTER_1_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Two_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character2;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_2_LINE_1,
                Line2 = CharacterConstants.CHARACTER_2_LINE_2,
                Line3 = CharacterConstants.CHARACTER_2_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Three_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character3;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_3_LINE_1,
                Line2 = CharacterConstants.CHARACTER_3_LINE_2,
                Line3 = CharacterConstants.CHARACTER_3_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Four_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character4;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_4_LINE_1,
                Line2 = CharacterConstants.CHARACTER_4_LINE_2,
                Line3 = CharacterConstants.CHARACTER_4_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Five_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character5;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_5_LINE_1,
                Line2 = CharacterConstants.CHARACTER_5_LINE_2,
                Line3 = CharacterConstants.CHARACTER_5_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Six_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character6;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_6_LINE_1,
                Line2 = CharacterConstants.CHARACTER_6_LINE_2,
                Line3 = CharacterConstants.CHARACTER_6_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Seven_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character7;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_7_LINE_1,
                Line2 = CharacterConstants.CHARACTER_7_LINE_2,
                Line3 = CharacterConstants.CHARACTER_7_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Eight_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character8;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_8_LINE_1,
                Line2 = CharacterConstants.CHARACTER_8_LINE_2,
                Line3 = CharacterConstants.CHARACTER_8_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Nine_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character9;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_9_LINE_1,
                Line2 = CharacterConstants.CHARACTER_9_LINE_2,
                Line3 = CharacterConstants.CHARACTER_9_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
        [TestMethod]
        public void Test_Conversion_Of_CharacterModel_Number_Zero_String_To_CharacterDefinition()
        {
            // Arrange
            var log = ServiceLocator.GetLogger(typeof(CharacterModelToCharacterDefinitionConverter));
            var characterModelToCharacterDefinitionConverter = new CharacterModelToCharacterDefinitionConverter(log);
            var characterDefinitions = new CharacterDefinitions();

            string expectedString = characterDefinitions.Character0;
            var characterModelData = new CharacterModel
            {
                Line = 0,
                Line1 = CharacterConstants.CHARACTER_0_LINE_1,
                Line2 = CharacterConstants.CHARACTER_0_LINE_2,
                Line3 = CharacterConstants.CHARACTER_0_LINE_3
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
    }
}