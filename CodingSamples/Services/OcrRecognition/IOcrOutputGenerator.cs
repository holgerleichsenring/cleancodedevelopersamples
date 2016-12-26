using System.Collections.Generic;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    ///     Write ocr processing result to console
    /// </summary>
    public interface IOcrOutputGenerator
    {
        /// <summary>
        ///     Write ocr processing result to console
        /// </summary>
        /// <param name="results">Results to be printed to Console</param>
        void Print(Dictionary<int, OcrProcessingModel> results);
    }
}