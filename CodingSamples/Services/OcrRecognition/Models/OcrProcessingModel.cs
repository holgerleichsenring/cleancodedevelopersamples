using System.Collections.Generic;

namespace CodingSamples.Services.OcrRecognition.Models
{
    public class OcrProcessingModel
    {
        public OcrProcessingModel()
        {
            Characters = new List<string>();
        }
        public int Line { get; set; }
        public List<string> Characters { get; set; }
        public bool LineContainsInvalidCharacters { get; set; }
    }
}
