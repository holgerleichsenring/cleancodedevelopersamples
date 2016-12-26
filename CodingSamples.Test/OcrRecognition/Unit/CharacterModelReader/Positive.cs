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
        public void Test_All_Possible_Numbers_In_One_Row_Resulting_In_Correct_List_Of_Numbers()
        {
            // Arrange

            var log = ServiceLocator.GetLogger(typeof (Services.OcrRecognition.CharacterModelReader));
            var lines = new List<LineModel>
            {
                new LineModel
                {
                    Line = 0,
                    Line1 = CharacterConstants.ALL_NUMBERS_LINE_1,
                    Line2 = CharacterConstants.ALL_NUMBERS_LINE_2,
                    Line3 = CharacterConstants.ALL_NUMBERS_LINE_3
                }
            };
            var characterModelReader = new Services.OcrRecognition.CharacterModelReader(log);
            var characterModelData = new List<CharacterModel>
            {
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_1, Line2 = CharacterConstants.CHARACTER_LINE_2_1, Line3 = CharacterConstants.CHARACTER_LINE_3_1},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_2, Line2 = CharacterConstants.CHARACTER_LINE_2_2, Line3 = CharacterConstants.CHARACTER_LINE_3_2},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_3, Line2 = CharacterConstants.CHARACTER_LINE_2_3, Line3 = CharacterConstants.CHARACTER_LINE_3_3},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_4, Line2 = CharacterConstants.CHARACTER_LINE_2_4, Line3 = CharacterConstants.CHARACTER_LINE_3_4},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_5, Line2 = CharacterConstants.CHARACTER_LINE_2_5, Line3 = CharacterConstants.CHARACTER_LINE_3_5},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_6, Line2 = CharacterConstants.CHARACTER_LINE_2_6, Line3 = CharacterConstants.CHARACTER_LINE_3_6},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_7, Line2 = CharacterConstants.CHARACTER_LINE_2_7, Line3 = CharacterConstants.CHARACTER_LINE_3_7},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_8, Line2 = CharacterConstants.CHARACTER_LINE_2_8, Line3 = CharacterConstants.CHARACTER_LINE_3_8},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_9, Line2 = CharacterConstants.CHARACTER_LINE_2_9, Line3 = CharacterConstants.CHARACTER_LINE_3_9},
                new CharacterModel {Line = 0, Line1 = CharacterConstants.CHARACTER_LINE_1_0, Line2 = CharacterConstants.CHARACTER_LINE_2_0, Line3 = CharacterConstants.CHARACTER_LINE_3_0}
            };
            //Act
            var result = characterModelReader.Read(lines);

            //Assert
            Assert.IsTrue(result.Count() == 10, $"Should have returned 10 characters but returned {result.Count()}.");
            var resultList = result.ToList();
            for (int index = 0; index < 10; index++)
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