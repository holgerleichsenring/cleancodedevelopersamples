using System;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Converts a character definition to a its numerical representation
    /// </summary>
    public class CharacterDefinitionToCharacterConverter : IConverter<string, string>
    {
        private readonly CharacterDefinitions _characterDefinitions;
        private readonly ILog _log;

        public CharacterDefinitionToCharacterConverter(ILog log, CharacterDefinitions characterDefinitions)
        {
            _log = log;
            _characterDefinitions = characterDefinitions;
            _log.Debug("ctor");
        }
        /// <summary>
        /// Converts a character definition to a its numerical representation
        /// </summary>
        /// <param name="source">a string that shall match the definition in <see cref="CharacterDefinitions"/> class </param>
        /// <returns>numerical representation of the character definition</returns>
        public string Convert(string source)
        {
            _log.Debug();
            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (_characterDefinitions.Characters.ContainsKey(source))
            {
                return _characterDefinitions.Characters[source];
            }

            throw new ArgumentException(nameof(source));
        }
    }
}