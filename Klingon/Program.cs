using FileManager;
using Klingon.Alphabet.Functions;
using Klingon.Alphabet.Structure;

namespace Klingon
{
    class Program
    {
        static void Main(string[] args)
        {

            FileReader reader = new FileReader();
            string text = reader.ParseFile("./assets/klingon-textoA.txt");

            KlingonFunctionFactory factory = new KlingonFunctionFactory();
            
            int prepositions = factory.Prepositions.Get(text).Count;
            int verbs = factory.Verbs.Get(text).Count;
            int firstPersonVerb = factory.Verbs.GetFirstPerson(text).Count;

            System.Console.WriteLine("Preposições no texto: " + prepositions);
            System.Console.WriteLine("Verbos no texto: " + verbs);
            System.Console.WriteLine("Verbos em primeira pessoa no texto: " + firstPersonVerb);
        }
    }
}
