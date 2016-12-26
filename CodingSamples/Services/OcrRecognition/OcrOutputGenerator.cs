using System;
using System.Collections.Generic;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    ///     Write ocr processing result to console
    /// </summary>
    public class OcrOutputGenerator : IOcrOutputGenerator
    {
        private readonly ILog _log;

        public OcrOutputGenerator(ILog log)
        {
            _log = log;
            _log.Debug("ctor");
        }

        /// <summary>
        ///     Write ocr processing result to console
        /// </summary>
        /// <param name="results">Results to be printed to Console</param>
        public void Print(Dictionary<int, OcrProcessingModel> results)
        {
            _log.Debug();
            const string LINE_WITH_ERROR = "Fehlerhafte Zeile";
            if (results == null)
            {
                throw new ArgumentNullException(nameof(results));
            }

            foreach (var item in results.Values)
            {
                string result;
                if (item.LineContainsInvalidCharacters)
                {
                    result = LINE_WITH_ERROR;
                }
                else
                {
                    result = string.Join("", item.Characters);
                }
                _log.Debug(result);
                Console.WriteLine(result);
            }
        }
    }
}