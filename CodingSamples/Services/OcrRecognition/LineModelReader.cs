using System;
using System.Collections.Generic;
using CodingSamples.Services.Interfaces;
using CodingSamples.Services.OcrRecognition.Models;

namespace CodingSamples.Services.OcrRecognition
{
    /// <summary>
    /// Creates list of <see cref="LineModel"/> instances from list of text lines
    /// </summary>
    public class LineModelReader : ILineModelReader
    {
        private readonly ILog _log;

        public LineModelReader(ILog log)
        {
            _log = log;
            _log.Debug("ctor");
        }
        /// <summary>
        /// Creates list of <see cref="LineModel"/> instances from list of text lines
        /// </summary>
        /// <param name="lines">list of strings</param>
        /// <returns>list of <see cref="LineModel"/> instances representing three lines each</returns>
        public IEnumerable<LineModel> Read(IEnumerable<string> lines)
        {
            _log.Debug();
            if (lines == null)
            {
                throw new ArgumentNullException(nameof(lines));
            }

            int counter = 0;
            var currentLines = new List<string>();
            var lineModels = new List<LineModel>();

            foreach (var line in lines)
            {
                currentLines.Add(line);
                counter++;
                if (counter % 3 == 0)
                {
                    var lineModel = new LineModel
                    {
                        Line1 = currentLines[0],
                        Line2 = currentLines[1],
                        Line3 = currentLines[2],
                        Line = counter / 3
                    };
                    currentLines = new List<string>();
                    lineModels.Add(lineModel);
                }
            }
            return lineModels;
        }
    }
}