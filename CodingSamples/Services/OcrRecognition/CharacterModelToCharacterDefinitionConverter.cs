using System;
using System.Text;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Converts a <see cref="CharacterModel"/> instance to more simple comparable <see cref="CharacterDefinitions"/> string representation.
    /// </summary>
    public class CharacterModelToCharacterDefinitionConverter : IConverter<CharacterModel, string>
    {
        private const char CHARACTER_PIPE = '|';
        private const char CHARACTER_UNDERSCORE = '_';
        private const char CHARACTER_SPACE = ' ';
        private const char CHARACTER_ZERO = '0';
        private const char CHARACTER_ONE = '1';
        private readonly ILog _log;

        public CharacterModelToCharacterDefinitionConverter(ILog log)
        {
            _log = log;
            _log.Debug("ctor");
        }
        /// <summary>
        /// Converts a <see cref="CharacterModel"/> instance to more simple comparable <see cref="CharacterDefinitions"/> string representation.
        /// </summary>
        /// <param name="source"><see cref="CharacterModel"/> instances to be converted, not null</param>
        /// <returns>CharacterModel string representation</returns>
        public string Convert(CharacterModel source)
        {
            _log.Debug();
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var stringBuilder = new StringBuilder();
            stringBuilder
                .Append(Transform(source.Line1))
                .Append(Transform(source.Line2))
                .Append(Transform(source.Line3));
            return stringBuilder.ToString();
        }

        private string Transform(string line)
        {
            return line
                .Replace(CHARACTER_PIPE, CHARACTER_ONE)
                .Replace(CHARACTER_UNDERSCORE, CHARACTER_ONE)
                .Replace(CHARACTER_SPACE, CHARACTER_ZERO);
        }
    }
}