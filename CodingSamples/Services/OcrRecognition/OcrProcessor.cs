using System;
using System.Collections.Generic;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Processes text file as Ocr processing sample
    /// </summary>
    public class OcrProcessor :IOcrProcessor
    {
        private readonly IConverter<string, string> _characterDefinitionToCharacterConverter;
        private readonly ICharacterModelReader _characterModelReader;
        private readonly IConverter<CharacterModel, string> _characterModelToCharacterDefinitionConverter;
        private readonly ILineModelReader _lineModelReader;
        private readonly ILineReader _lineReader;
        private readonly ILog _log;

        public OcrProcessor(ILog log, ILineReader lineReader, ILineModelReader lineModelReader, ICharacterModelReader characterModelReader,
            IConverter<CharacterModel, string> characterModelToCharacterDefinitionConverter,
            IConverter<string, string> characterDefinitionToCharacterConverter)
        {
            _log = log;
            _lineReader = lineReader;
            _lineModelReader = lineModelReader;
            _characterModelReader = characterModelReader;
            _characterModelToCharacterDefinitionConverter = characterModelToCharacterDefinitionConverter;
            _characterDefinitionToCharacterConverter = characterDefinitionToCharacterConverter;
            _log.Debug("ctor");
        }

        /// <summary>
        /// Process ocr recognition on filename
        /// </summary>
        /// <param name="fileName">The filename to process ocr recognition on</param>
        /// <returns>List of <see cref="OcrProcessingModel"/> containing all recognized characters, included in a dictionary where the key is the line number </returns>
        public Dictionary<int, OcrProcessingModel> Process(string fileName)
        {
            _log.Debug();
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            var lines = _lineReader.Read(fileName);
            var lineModels = _lineModelReader.Read(lines);
            var characterModels = _characterModelReader.Read(lineModels);

            return GetOcrProcessingModels(characterModels);
        }

        private Dictionary<int, OcrProcessingModel> GetOcrProcessingModels(IEnumerable<CharacterModel> characterModels)
        {
            var charactersPerLine = new Dictionary<int, OcrProcessingModel>();
            foreach (CharacterModel characterModel in characterModels)
            {
                var characterDefinition = _characterModelToCharacterDefinitionConverter.Convert(characterModel);
                string character;
                bool invalid = false;
                try
                {
                    character = _characterDefinitionToCharacterConverter.Convert(characterDefinition);
                }
                catch (ArgumentException)
                {
                    character = "##NA##";
                    invalid = true;
                }
                if (!charactersPerLine.ContainsKey(characterModel.Line))
                {
                    charactersPerLine.Add(characterModel.Line, new OcrProcessingModel());
                }
                var ocrProcessingModel = charactersPerLine[characterModel.Line];
                ocrProcessingModel.Characters.Add(character);
                ocrProcessingModel.LineContainsInvalidCharacters |= invalid;
            }
            return charactersPerLine;
        }
    }
}