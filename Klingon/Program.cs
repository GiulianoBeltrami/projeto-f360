using FileManager;
using Klingon.Factory;

namespace Klingon
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = FileReader.ParseFile("./assets/klingon-textoA.txt");

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
