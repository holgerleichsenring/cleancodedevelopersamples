using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingSamples.Test.OcrRecognition.Unit.FileReader
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        [ExpectedException(typeof (FileNotFoundException))]
        public void Test_Shall_Raise_File_Not_Found_On_Non_Existing_File_Name()
        {
            // Arrange
            var fileReader = new Services.OcrRecognition.FileReader();

            //Act
            var result = fileReader.OpenText("NonExistingFileName");

            //Assert
            Assert.Fail("Test should fail as file does not exist.");
        }
    }
}