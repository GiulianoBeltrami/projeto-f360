using System.Collections.Generic;
using System.Linq;

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
        private string _text;
        public Prepositions(string text)
        {
            _text = text;
        }

        public List<string> Get()
        {
            List<string> prepositions = new List<string>();

            if (IsLengthThree() && IsLastLetterBar() && DoesntContainLetterD())
            {
                prepositions.Add(_text);
            }

            return prepositions;
        }

        private string[] SplitText()
        {
            return _text.Split(' ');
        }

        private bool IsLengthThree()
        {
            return _text.Length == 3;
        }

        private bool IsLastLetterBar()
        {
            Bar bar = new Bar();
            List<string> BarLetters = bar.Get();

            return BarLetters.Contains(_text[_text.Length - 1].ToString());
        }

        private bool DoesntContainLetterD()
        {
            return !_text.Contains("d");
        }
    }
}