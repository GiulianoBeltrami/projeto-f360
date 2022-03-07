using System.Collections.Generic;
using FileManager;
using Klingon.Alphabet.Structure;
using Klingon.Factory;
using Klingon.Numbers;

namespace Klingon
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = FileReader.ParseFile("./assets/klingon-textoB.txt");

            KlingonGrammarFactory grammarFactory = new KlingonGrammarFactory();
            KlingonVocabularyFactory vocabularyFactory = new KlingonVocabularyFactory();
            KlingonNumberFactory numberFactory = new KlingonNumberFactory();

            int prepositions = grammarFactory.Prepositions.Get(text).Count;
            int verbs = grammarFactory.Verbs.Get(text).Count;
            int firstPersonVerb = grammarFactory.Verbs.GetFirstPerson(text).Count;
            string vocabularyText = vocabularyFactory.Vocabulary.Get(text);
            double numbers = numberFactory.Number.GetBeautiful(text).Count;

            System.Console.WriteLine("Preposições no texto: " + prepositions);
            System.Console.WriteLine("Verbos no texto: " + verbs);
            System.Console.WriteLine("Verbos em primeira pessoa no texto: " + firstPersonVerb);
            System.Console.WriteLine(vocabularyText);
            System.Console.WriteLine("Números bonitos: " + numbers);
        }
    }
}
