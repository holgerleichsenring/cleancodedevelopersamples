using System.Collections.Generic;

namespace CodingSamples.Services.OcrRecognition.Models
{
    public class CharacterDefinitions
    {
        /*
         * Characters are defined like this:
         *      _
         *   |  _| 
         *   | |_ 
         * Every character has three lines and three columns
         * Every character is separated by a space
         * Characters consists of _ and |
         * 
         * To make recognition more easy, these characters can be seen as
         * 
         * Number 1:
         * 000
         * 001
         * 001
         * 
         * Instead of considering three lines and comparing matrices it is much more easy and unique to just use strings:
         * 000001001
         * 
         */

        public CharacterDefinitions()
        {
            Characters = new Dictionary<string, string>
            {
                {Character0, "0"},
                {Character1, "1"},
                {Character2, "2"},
                {Character3, "3"},
                {Character4, "4"},
                {Character5, "5"},
                {Character6, "6"},
                {Character7, "7"},
                {Character8, "8"},
                {Character9, "9"},
            };
        }

        public string Character1 => "000001001";
        public string Character2 => "010011110";
        public string Character3 => "010011011";
        public string Character4 => "000111001";
        public string Character5 => "010110011";
        public string Character6 => "010110111";
        public string Character7 => "010001001";
        public string Character8 => "010111111";
        public string Character9 => "010111011";
        public string Character0 => "010101111";

        public readonly Dictionary<string, string> Characters;
    }
}
