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
                Line1 = CharacterConstants.CHARACTER_LINE_1_1,
                Line2 = CharacterConstants.CHARACTER_LINE_2_1,
                Line3 = CharacterConstants.CHARACTER_LINE_3_1
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_2,
                Line2 = CharacterConstants.CHARACTER_LINE_2_2,
                Line3 = CharacterConstants.CHARACTER_LINE_3_2
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_3,
                Line2 = CharacterConstants.CHARACTER_LINE_2_3,
                Line3 = CharacterConstants.CHARACTER_LINE_3_3
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_4,
                Line2 = CharacterConstants.CHARACTER_LINE_2_4,
                Line3 = CharacterConstants.CHARACTER_LINE_3_4
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_5,
                Line2 = CharacterConstants.CHARACTER_LINE_2_5,
                Line3 = CharacterConstants.CHARACTER_LINE_3_5
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_6,
                Line2 = CharacterConstants.CHARACTER_LINE_2_6,
                Line3 = CharacterConstants.CHARACTER_LINE_3_6
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_7,
                Line2 = CharacterConstants.CHARACTER_LINE_2_7,
                Line3 = CharacterConstants.CHARACTER_LINE_3_7
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_8,
                Line2 = CharacterConstants.CHARACTER_LINE_2_8,
                Line3 = CharacterConstants.CHARACTER_LINE_3_8
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_9,
                Line2 = CharacterConstants.CHARACTER_LINE_2_9,
                Line3 = CharacterConstants.CHARACTER_LINE_3_9
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
                Line1 = CharacterConstants.CHARACTER_LINE_1_0,
                Line2 = CharacterConstants.CHARACTER_LINE_2_0,
                Line3 = CharacterConstants.CHARACTER_LINE_3_0
            };

            //Act
            var result = characterModelToCharacterDefinitionConverter.Convert(characterModelData);

            //Assert
            Assert.IsTrue(result == expectedString, $"Converter should have returned {expectedString} but returned {result}.");
        }
    }
}