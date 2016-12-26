using System;
using System.Collections.Generic;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Reads out characters from <see cref="LineModel" /> list
    /// </summary>
    public class CharacterModelReader : ICharacterModelReader
    {
        private readonly ILog _log;

        public CharacterModelReader(ILog log)
        {
            _log = log;
            _log.Debug("ctor");
        }

        /// <summary>
        /// Reads out characters from <see cref="LineModel" /> list and returns list of CharacterModels
        /// </summary>
        /// <param name="lineModels">LineModel instance containing charaters in three lines to be converted to CharacterModels</param>
        /// <returns>List of CharacterModels representing all single characters in lineModels </returns>
        public IEnumerable<CharacterModel> Read(IEnumerable<LineModel> lineModels)
        {
            _log.Debug();
            if (lineModels == null)
            {
                throw new ArgumentNullException(nameof(lineModels));
            }

            var characterModels = new List<CharacterModel>();
            foreach (var lineModel in lineModels)
            {
                if (Validate(lineModel))
                {
                    for (int index = 0; index <= lineModel.Line1.Length / 4; index++)
                    {
                        var characterModel = new CharacterModel
                        {
                            Line1 = lineModel.Line1.Substring(index * 4, 3),
                            Line2 = lineModel.Line2.Substring(index * 4, 3),
                            Line3 = lineModel.Line3.Substring(index * 4, 3),
                            Line = lineModel.Line
                        };
                        characterModels.Add(characterModel);
                    }
                }
            }
            return characterModels;
        }

        private bool Validate(LineModel lineModel)
        {
            if (lineModel.Line1.Length != lineModel.Line2.Length ||
                lineModel.Line1.Length != lineModel.Line3.Length ||
                lineModel.Line2.Length != lineModel.Line3.Length)
            {
                return false;
            }

            // every line shall have n characters separted by spaces in between but not at the end of the line
            if (lineModel.Line1.Length % 4 != 3)
            {
                return false;
            }
            return true;
        }
    }
}