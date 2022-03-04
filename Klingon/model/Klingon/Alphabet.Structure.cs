using System.Collections.Generic;

namespace Klingon.Alphabet.Structure
{
    public static class AlphabetOrder
    {
        public static string Get()
        {
            return "kbwrqdnfxjmlvhtcgzps";
        }
    }

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
                "k", "b", "w", "r", "q", "d", "n", "f", "x", "j", "m", "l", "v", "h", "t", "c", "g", "z", "p", "s"
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