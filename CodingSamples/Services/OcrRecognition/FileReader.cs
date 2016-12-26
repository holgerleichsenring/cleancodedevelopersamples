using System.IO;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// File Reader wrapper 
    /// </summary>
    public class FileReader : IFileReader
    {
        /// <summary>
        /// Opens an existing UTF-8 text file for reading
        /// </summary>
        /// <param name="fileName">file to be read</param>
        /// <returns>StreamReader instance</returns>
        public StreamReader OpenText(string fileName)
        {
            return File.OpenText(fileName);
        }
    }
}