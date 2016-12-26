using System.Collections.Generic;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Reads out text file to a list of strings
    /// </summary>
    public interface ILineReader
    {
        /// <summary>
        /// Reads out text file to a list of strings
        /// </summary>
        /// <param name="fileName">Name of file to be read out</param>
        /// <returns>List of lines representing each line in file</returns>
        IEnumerable<string> Read(string fileName);
    }
}