using System;
using System.IO;
using CodingSamples.Services;
using CodingSamples.Services.OcrRecognition;

namespace CodingSamples.Console
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("Invalid count of args. Please provide filename for ocr processing.");
                return 1;
            }

            string fileName = args[0];
            if (!File.Exists(fileName))
            {
                System.Console.WriteLine($"File {fileName} does not exist. Please provide fileName to existing file.");
                return 1;
            }

            try
            {
                var bootstrapper = new Bootstrapper();
                bootstrapper.Initialize();

                var ocrProcessor = ServiceLocator.Resolve<IOcrProcessor>();
                var result = ocrProcessor.Process(fileName);
                var ocrOutputGenerator = ServiceLocator.Resolve<IOcrOutputGenerator>();
                ocrOutputGenerator.Print(result);
                return 0;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Failed to process file {fileName} with exception {ex.Message}.");
                return 1;
            }
        }
    }
}