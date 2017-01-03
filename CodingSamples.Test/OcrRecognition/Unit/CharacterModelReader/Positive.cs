using System.Collections.Generic;
using System.Linq;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.CharacterModelReader
{
    [TestClass]
    public class Positive
    {
        [TestMethod]
        public void Test_1234567890_In_One_Row()
        {
            // Arrange

            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.CharacterModelReader));
            var lines = new List<LineModel>
            {
                new LineModel
                {
                    Line = 0,
                    Line1 = CharacterConstants.NUMBERS_1234567890_LINE_1,
                    Line2 = CharacterConstants.NUMBERS_1234567890_LINE_2,
                    Line3 = CharacterConstants.NUMBERS_1234567890_LINE_3
                }
            };
            var characterModelReader = new Services.OcrRecognition.CharacterModelReader(log);
            var characterModelData = new List<CharacterModel>
            {
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_1_LINE_1, Line2 = CharacterConstants.CHARACTER_1_LINE_2, Line3 = CharacterConstants.CHARACTER_1_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_2_LINE_1, Line2 = CharacterConstants.CHARACTER_2_LINE_2, Line3 = CharacterConstants.CHARACTER_2_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_3_LINE_1, Line2 = CharacterConstants.CHARACTER_3_LINE_2, Line3 = CharacterConstants.CHARACTER_3_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_4_LINE_1, Line2 = CharacterConstants.CHARACTER_4_LINE_2, Line3 = CharacterConstants.CHARACTER_4_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_5_LINE_1, Line2 = CharacterConstants.CHARACTER_5_LINE_2, Line3 = CharacterConstants.CHARACTER_5_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_6_LINE_1, Line2 = CharacterConstants.CHARACTER_6_LINE_2, Line3 = CharacterConstants.CHARACTER_6_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_7_LINE_1, Line2 = CharacterConstants.CHARACTER_7_LINE_2, Line3 = CharacterConstants.CHARACTER_7_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_8_LINE_1, Line2 = CharacterConstants.CHARACTER_8_LINE_2, Line3 = CharacterConstants.CHARACTER_8_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_9_LINE_1, Line2 = CharacterConstants.CHARACTER_9_LINE_2, Line3 = CharacterConstants.CHARACTER_9_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_0_LINE_1, Line2 = CharacterConstants.CHARACTER_0_LINE_2, Line3 = CharacterConstants.CHARACTER_0_LINE_3}
            };
            //Act
            var result = characterModelReader.Read(lines);

            //Assert
            TestAndAssert(result, characterModelData);
        }
        [TestMethod]
        public void Test_815_In_One_Row()
        {
            // Arrange

            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterModelReader));
            var lines = new List<LineModel>
            {
                new LineModel
                {
                    Line = 0,
                    Line1 = CharacterConstants.NUMBERS_815_LINE_1,
                    Line2 = CharacterConstants.NUMBERS_815_LINE_2,
                    Line3 = CharacterConstants.NUMBERS_815_LINE_3
                }
            };
            var characterModelReader = new Services.OcrRecognition.CharacterModelReader(log);
            var characterModelData = new List<CharacterModel>
            {
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_8_LINE_1, Line2 = CharacterConstants.CHARACTER_8_LINE_2, Line3 = CharacterConstants.CHARACTER_8_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_1_LINE_1, Line2 = CharacterConstants.CHARACTER_1_LINE_2, Line3 = CharacterConstants.CHARACTER_1_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_5_LINE_1, Line2 = CharacterConstants.CHARACTER_5_LINE_2, Line3 = CharacterConstants.CHARACTER_5_LINE_3},
            };
            //Act
            var result = characterModelReader.Read(lines);

            //Assert
            TestAndAssert(result, characterModelData);
        }
        [TestMethod]
        public void Test_42_In_One()
        {
            // Arrange

            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterModelReader));
            var lines = new List<LineModel>
            {
                new LineModel
                {
                    Line = 0,
                    Line1 = CharacterConstants.NUMBERS_42_LINE_1,
                    Line2 = CharacterConstants.NUMBERS_42_LINE_2,
                    Line3 = CharacterConstants.NUMBERS_42_LINE_3
                }
            };
            var characterModelReader = new Services.OcrRecognition.CharacterModelReader(log);
            var characterModelData = new List<CharacterModel>
            {
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_4_LINE_1, Line2 = CharacterConstants.CHARACTER_4_LINE_2, Line3 = CharacterConstants.CHARACTER_4_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_2_LINE_1, Line2 = CharacterConstants.CHARACTER_2_LINE_2, Line3 = CharacterConstants.CHARACTER_2_LINE_3},
            };
            //Act
            var result = characterModelReader.Read(lines);

            //Assert
            TestAndAssert(result, characterModelData);
        }
        [TestMethod]
        public void Test_07_In_One_Row()
        {
            // Arrange

            var log = ServiceLocator.GetLogger(typeof(Services.OcrRecognition.CharacterModelReader));
            var lines = new List<LineModel>
            {
                new LineModel
                {
                    Line = 0,
                    Line1 = CharacterConstants.NUMBERS_07_LINE_1,
                    Line2 = CharacterConstants.NUMBERS_07_LINE_2,
                    Line3 = CharacterConstants.NUMBERS_07_LINE_3
                }
            };
            var characterModelReader = new Services.OcrRecognition.CharacterModelReader(log);
            var characterModelData = new List<CharacterModel>
            {
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_0_LINE_1, Line2 = CharacterConstants.CHARACTER_0_LINE_2, Line3 = CharacterConstants.CHARACTER_0_LINE_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_7_LINE_1, Line2 = CharacterConstants.CHARACTER_7_LINE_2, Line3 = CharacterConstants.CHARACTER_7_LINE_3},
            };
            //Act
            var result = characterModelReader.Read(lines);

            //Assert
            TestAndAssert(result, characterModelData);
        }

        private static void TestAndAssert(IEnumerable<CharacterModel> result, List<CharacterModel> characterModelData)
        {
            int count = characterModelData.Count;
            Assert.IsTrue(result.Count() == count, $"Should have returned {count} characters but returned {result.Count()}.");
            var resultList = result.ToList();
            for (int index = 0; index < count; index++)
            {
                var resultModelItem = resultList[index];
                var characterModelItem = characterModelData[index];
                Assert.IsTrue(resultModelItem.Line == characterModelItem.Line,
                    $"Should have returned line {characterModelItem.Line} but returned {resultModelItem.Line}.");
                Assert.IsTrue(resultModelItem.Line1 == characterModelItem.Line1,
                    $"Should have returned line {characterModelItem.Line1} but returned {resultModelItem.Line1}.");
                Assert.IsTrue(resultModelItem.Line2 == characterModelItem.Line2,
                    $"Should have returned line {characterModelItem.Line2} but returned {resultModelItem.Line2}.");
                Assert.IsTrue(resultModelItem.Line3 == characterModelItem.Line3,
                    $"Should have returned line {characterModelItem.Line3} but returned {resultModelItem.Line3}.");
            }
        }
    }
}