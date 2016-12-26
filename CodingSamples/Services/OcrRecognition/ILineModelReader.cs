using System.Collections.Generic;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Creates list of <see cref="LineModel"/> instances from list of text lines
    /// </summary>
    public interface ILineModelReader
    {
        /// <summary>
        /// Creates list of <see cref="LineModel"/> instances from list of text lines
        /// </summary>
        /// <param name="lines">list of strings</param>
        /// <returns>list of <see cref="LineModel"/> instances representing three lines each</returns>
        IEnumerable<LineModel> Read(IEnumerable<string> lines);
    }
}