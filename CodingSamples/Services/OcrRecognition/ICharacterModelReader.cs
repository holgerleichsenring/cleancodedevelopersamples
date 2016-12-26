using System.Collections.Generic;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Reads out characters from <see cref="LineModel" /> list
    /// </summary>
    public interface ICharacterModelReader
    {
        /// <summary>
        /// Reads out characters from <see cref="LineModel" /> list and returns list of CharacterModels
        /// </summary>
        /// <param name="lineModels">LineModel instance containing charaters in three lines to be converted to CharacterModels</param>
        /// <returns>List of CharacterModels representing all single characters in lineModels </returns>
        IEnumerable<CharacterModel> Read(IEnumerable<LineModel> lineModels);
    }
}