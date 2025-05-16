using System;
using System.Collections.Generic;

namespace GuessTheWord
{
    public class Model
    {
        public IDictionary<string, string> wordsWithHints = new Dictionary<string, string>
        {
            { "apple", "fruit" },
            { "banana", "fruit" },
            { "tiger", "animal" },
            { "elephant", "animal" },
            { "guitar", "instrument" },
            { "violin", "instrument" },
            { "canada", "country" },
            { "brazil", "country" },
            { "laptop", "object" },
            { "microscope", "scientific instrument" }

        };
        
    }
}