using System.Collections.Generic;
using Interfaces.Klingon.Structure;
using TextHandler;
namespace Klingon.Alphabet.Grammar
{
    public class Prepositions
    {
        private IKlingonStructure _klingonStructure;

        public Prepositions(IKlingonStructure klingonStructure)
        {
            _klingonStructure = klingonStructure;
        }

        public List<string> Get(string text)
        {
            string[] _text = TextFormatter.LowerTextAndSplit(text);
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
            List<string> BarLetters = _klingonStructure.Bar.Get();

            return BarLetters.Contains(text[text.Length - 1].ToString());
        }

        private bool DoesntContainLetterD(string text)
        {
            return !text.Contains("d");
        }
    }

    public class Verbs
    {
        private IKlingonStructure _klingonStructure;
        public Verbs(IKlingonStructure klingonStructure)
        {
            _klingonStructure = klingonStructure;
        }

        public List<string> Get(string text)
        {
            string[] _text = TextFormatter.LowerTextAndSplit(text);
            List<string> Verbs = new List<string>();

            foreach (string word in _text)
            {
                if (IsVerbConditionMeet(word))
                {
                    Verbs.Add(word);
                }
            }
            return Verbs;
        }

        public List<string> GetFirstPerson(string text)
        {
            List<string> AllVerbs = Get(text);
            List<string> FirstPersonVerbs = new List<string>();
            foreach (string word in AllVerbs)
            {
                if (IsFirstLetterBar(word))
                {
                    FirstPersonVerbs.Add(word);
                }
            }
            return FirstPersonVerbs;
        }

        private bool IsVerbConditionMeet(string text)
        {
            return IsLengthGreaterOrEqualEigth(text) && IsLastLetterFoo(text);
        }

        private bool IsLengthGreaterOrEqualEigth(string text)
        {
            return text.Length >= 8;
        }

        private bool IsLastLetterFoo(string text)
        {
            List<string> FooLetters = _klingonStructure.Foo.Get();

            return FooLetters.Contains(text[text.Length - 1].ToString());
        }

        private bool IsFirstLetterBar(string text)
        {
            List<string> BarLetters = _klingonStructure.Bar.Get();

            return BarLetters.Contains(text[0].ToString());
        }
    }
}