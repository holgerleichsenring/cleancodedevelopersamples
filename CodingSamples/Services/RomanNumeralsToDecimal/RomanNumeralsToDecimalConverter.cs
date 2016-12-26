using System;
using System.Linq;
using CodingSamples.Services.Interfaces;

namespace CodingSamples.Services.RomanNumeralsToDecimal
{
    /// <summary>
    /// Converts Roman Numerals to decimals.
    /// </summary>
    public class RomanNumeralsToDecimalConverter : IConverter<string, int>
    {
        private const char ROMAN_NUMERALS_M = 'M';
        private const char ROMAN_NUMERALS_D = 'D';
        private const char ROMAN_NUMERALS_C = 'C';
        private const char ROMAN_NUMERALS_L = 'L';
        private const char ROMAN_NUMERALS_X = 'X';
        private const char ROMAN_NUMERALS_V = 'V';
        private const char ROMAN_NUMERALS_I = 'I';
        private const string VALID_ROMAN_NUMERALS = "MDCLXVI";
        
        /// <summary>
        /// Converts Roman Numerals to decimals
        /// </summary>
        /// <param name="value">Roman Numeral string value to be converted</param>
        /// <returns>decimal representation of Roman number</returns>
        public int Convert(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (!Validate(value))
            {
                //TODO: enhance exception handling to inform user about which character has been invalid
                //TODO: program will not detect invalid combinations, enhance.
                throw new ArgumentException("Value contains invalid characters. Valid characters are M, D, C, L, X, V, I");
            }

            int valueLength = value.Length;
            int sum = 0;
            for (int i = 0; i < valueLength; i++)
            {
                char currentCharacter = value[i];
                bool isLastCharacter = i == valueLength - 1;

                switch (currentCharacter)
                {
                    case ROMAN_NUMERALS_M:
                        sum += 1000;
                        break;
                    case ROMAN_NUMERALS_D:
                        if (!isLastCharacter && value[i + 1] == ROMAN_NUMERALS_M)
                        {
                            sum -= 500;
                            break;
                        }
                        sum += 500;
                        break;
                    case ROMAN_NUMERALS_C:
                        if (!isLastCharacter && (value[i + 1] == ROMAN_NUMERALS_M || value[i + 1] == ROMAN_NUMERALS_D))
                        {
                            sum -= 100;
                            break;
                        }
                        sum += 100;
                        break;
                    case ROMAN_NUMERALS_L:
                        sum += 50;
                        break;
                    case ROMAN_NUMERALS_X:
                        if (!isLastCharacter && (value[i + 1] == ROMAN_NUMERALS_L || value[i + 1] == ROMAN_NUMERALS_C))
                        {
                            sum -= 10;
                            break;
                        }
                        sum += 10;
                        break;
                    case ROMAN_NUMERALS_V:
                        sum += 5;
                        break;
                    case ROMAN_NUMERALS_I:
                        if (!isLastCharacter && (value[i + 1] == ROMAN_NUMERALS_X || value[i + 1] == ROMAN_NUMERALS_V))
                        {
                            sum -= 1;
                            break;
                        }
                        sum += 1;
                        break;
                }
            }
            return sum;
        }

        private bool Validate(string value)
        {
            return value.All(character => VALID_ROMAN_NUMERALS.Contains(character.ToString()));
        }
    }
}
