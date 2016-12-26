using System;
using System.Collections.Generic;
using CodingSamples.Services.Interfaces;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Reads out text file to a list of strings
    /// </summary>
    public class LineReader : ILineReader
    {
        private readonly IFileReader _fileReader;
        private readonly ILog _log;

        public LineReader(ILog log, IFileReader fileReader)
        {
            _log = log;
            _fileReader = fileReader;
            _log.Debug("ctor");
        }
        /// <summary>
        /// Reads out text file to a list of strings
        /// </summary>
        /// <param name="fileName">Name of file to be read out</param>
        /// <returns>List of lines representing each line in file</returns>
        public IEnumerable<string> Read(string fileName)
        {
            _log.Debug();
            //TODO: Consider performance and memory consumption in brute force approach reading all at once.
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            var lines = new List<string>();
            using (var reader = _fileReader.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    _log.Debug($"line: {line}");
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}