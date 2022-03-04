using System.Collections.Generic;

namespace Klingon.Alphabet.Structure
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

}