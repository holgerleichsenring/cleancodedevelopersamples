using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CodingSamples.Services;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.Logging;
using CodingSamples.Services.OcrRecognition;
using CodingSamples.Services.OcrRecognition.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace CodingSamples.Test.OcrRecognition.System
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_Processing_Of_One_Line_With_10_Numbers()
        {
            // Arrange
            var lineReaderSubstitute = Substitute.For<ILineReader>();
            lineReaderSubstitute.Read("NotExistingFileName").Returns(new List<string>
            {
                CharacterConstants.NUMBERS_1234567890_LINE_1,
                CharacterConstants.NUMBERS_1234567890_LINE_2,
                CharacterConstants.NUMBERS_1234567890_LINE_3,
            });

            BootstrapApplication(lineReaderSubstitute);
            var ocrProcessor = ServiceLocator.Resolve<IOcrProcessor>();

            //Act
            var result = ocrProcessor.Process("NotExistingFileName");

            //Assert
            Assert.IsTrue(result.Keys.Count == 1, $"Processing ocr failed: Should be 1 line but are {result.Keys.Count}");

            var line = result[1];
            int expectedCount = 10;
            string expectedString = "1234567890";

            CheckForFailure(expectedCount, expectedString, line);
        }
        [TestMethod]
        public void Test_Processing_Of_Four_Lines_And_Different_Numbers()
        {
            // Arrange
            var lineReaderSubstitute = Substitute.For<ILineReader>();
            lineReaderSubstitute.Read("NotExistingFileName").Returns(new List<string>
            {
                CharacterConstants.NUMBERS_1234567890_LINE_1,
                CharacterConstants.NUMBERS_1234567890_LINE_2,
                CharacterConstants.NUMBERS_1234567890_LINE_3,
                CharacterConstants.NUMBERS_815_LINE_1,
                CharacterConstants.NUMBERS_815_LINE_2,
                CharacterConstants.NUMBERS_815_LINE_3,
                CharacterConstants.NUMBERS_42_LINE_1,
                CharacterConstants.NUMBERS_42_LINE_2,
                CharacterConstants.NUMBERS_42_LINE_3,
                CharacterConstants.NUMBERS_07_LINE_1,
                CharacterConstants.NUMBERS_07_LINE_2,
                CharacterConstants.NUMBERS_07_LINE_3,
            });

            BootstrapApplication(lineReaderSubstitute);

            var ocrProcessor = ServiceLocator.Resolve<IOcrProcessor>();

            //Act
            var result = ocrProcessor.Process("NotExistingFileName");

            //Assert
            Assert.IsTrue(result.Keys.Count == 4, $"Processing ocr failed: Should be 4 line but are {result.Keys.Count}");

            //line 1
            var line = result[1];
            int expectedCount = 10;
            string expectedString = "1234567890";

            CheckForFailure(expectedCount, expectedString, line);

            //line 2
            line = result[2];

            expectedCount = 3;
            expectedString = "815";

            CheckForFailure(expectedCount, expectedString, line);

            //line 3
            line = result[3];

            expectedCount = 2;
            expectedString = "42";

            CheckForFailure(expectedCount, expectedString, line);

            //line 4
            line = result[4];

            expectedCount = 2;
            expectedString = "07";

            CheckForFailure(expectedCount, expectedString, line);
        }

        private static void BootstrapApplication(ILineReader lineReaderSubstitute)
        {
            WindsorContainer container = new WindsorContainer();
            container.AddFacility<LogTypeResolverFacility>();
            container.Register(Component.For<IConverter<string, string>>().ImplementedBy<CharacterDefinitionToCharacterConverter>());
            container.Register(Component.For<IConverter<CharacterModel, string>>().ImplementedBy<CharacterModelToCharacterDefinitionConverter>());
            container.Register(Component.For<ICharacterModelReader>().ImplementedBy<CharacterModelReader>());
            container.Register(Component.For<ILineModelReader>().ImplementedBy<LineModelReader>());
            container.Register(Component.For<CharacterDefinitions>());
            container.Register(Component.For<IOcrProcessor>().ImplementedBy<OcrProcessor>());
            container.Register(Component.For<IOcrOutputGenerator>().ImplementedBy<OcrOutputGenerator>());
            container.Register(Component.For<ILineReader>().Instance(lineReaderSubstitute));
            ServiceLocator.Initialize(container);
        }

        private void CheckForFailure(int expectedCount, string expectedString, OcrProcessingModel line)
        {
            var characters = line.Characters;
            Assert.IsTrue(characters.Count == expectedCount, $"Processing ocr failed: Should be {expectedCount} recognized characters but are {characters.Count}");
            Assert.IsFalse(line.LineContainsInvalidCharacters, $"Processing ocr failed: Should be {expectedCount} recognized characters but has unindentified");
            string characterResult = string.Join("", line.Characters);
            Assert.IsTrue(characterResult == expectedString, $"Processing ocr failed: Result should be {expectedString} but is {characterResult}");

        }
    }
}