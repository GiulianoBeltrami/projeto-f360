using System;
using System.Collections.Generic;
using System.Linq;
using Klingon.Alphabet.Comparer;
using TextHandler;

namespace Klingon.Alphabet.Vocabulary
{
    public class Vocabulary
    {
        public string Get(string text)
        {
            string[] _text = TextFormatter.LowerTextAndSplit(text);
            List<string> newText = TextProcessor.RemoveDuplicates(_text);

            newText.Sort(new KlingonComparer());

            return String.Join(" ",newText);
        }
    }
}