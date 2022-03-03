using System.Collections.Generic;
using TextHandler;

namespace KlingonAlphabet
{

    public class Foo
    {
        private List<string> _fooLetters;

        public Foo()
        {
            _fooLetters = new List<string>() { "s", "l", "f", "w", "k" };
        }

        public List<string> Get()
        {
            return _fooLetters;
        }
    }

    public class Bar
    {
        private List<string> _fooLetters;
        private List<string> _barLetters = new List<string>();

        public Bar()
        {
            _fooLetters = new Foo().Get();
        }

        public List<string> Get()
        {
            List<string> alphabet = new List<string>()
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            foreach (var letter in alphabet)
            {
                if (!_fooLetters.Contains(letter))
                {
                    _barLetters.Add(letter);
                }
            }

            return _barLetters;
        }
    }

    public class Prepositions
    {
        private string[] _text;
        
        public Prepositions(string text)
        {
            TextFormatter textFormatter = new TextFormatter(text);
            _text = textFormatter.SplitText();
        }

        public List<string> Get()
        {
            List<string> prepositions = new List<string>();

            foreach (string word in _text)
            {
                if (IsPrepositionConditionMeet(word))
                {
                    prepositions.Add(word);
                }
            }

            return prepositions;
        }

        private string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        private bool IsPrepositionConditionMeet(string text)
        {
            return IsLengthThree(text) && IsLastLetterBar(text) && DoesntContainLetterD(text);
        }

        private bool IsLengthThree(string text)
        {
            return text.Length == 3;
        }

        private bool IsLastLetterBar(string text)
        {
            Bar bar = new Bar();
            List<string> BarLetters = bar.Get();

            return BarLetters.Contains(text[text.Length - 1].ToString());
        }

        private bool DoesntContainLetterD(string text)
        {
            return !text.Contains("d");
        }
    }

    public class Verbs
    {
        public Verbs()
        {

        }
    }
}