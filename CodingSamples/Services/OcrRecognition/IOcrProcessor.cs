using System.Collections.Generic;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Processes text file as Ocr processing sample
    /// </summary>
    public interface IOcrProcessor 
    {
        /// <summary>
        /// Process ocr recognition on filename
        /// </summary>
        /// <param name="fileName">The filename to process ocr recognition on</param>
        /// <returns>List of <see cref="OcrProcessingModel"/> containing all recognized characters, included in a dictionary where the key is the line number </returns>
        Dictionary<int, OcrProcessingModel> Process(string fileName);
    }
}