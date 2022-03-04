using System.Collections.Generic;
using FileManager;
using Klingon.Alphabet.Comparer;
using Klingon.Alphabet.Vocabulary;
using Klingon.Factory;

namespace Klingon
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = FileReader.ParseFile("./assets/klingon-textoA.txt");

            KlingonGrammarFactory factory = new KlingonGrammarFactory();

            int prepositions = factory.Prepositions.Get(text).Count;
            int verbs = factory.Verbs.Get(text).Count;
            int firstPersonVerb = factory.Verbs.GetFirstPerson(text).Count;
            
            Vocabulary v = new Vocabulary();

            System.Console.WriteLine("Preposições no texto: " + prepositions);
            System.Console.WriteLine("Verbos no texto: " + verbs);
            System.Console.WriteLine("Verbos em primeira pessoa no texto: " + firstPersonVerb);
            System.Console.WriteLine(v.Get("kkqrz kkqrz kkr kkr"));
        }
    }
}
