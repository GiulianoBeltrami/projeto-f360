using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using FileManager;
using KlingonAlphabet;

namespace Klingon
{
    class Program
    {
        static void Main(string[] args)
        {

            Foo foo = new Foo();
            Bar bar = new Bar();
            List<string> FooLetters = foo.Get();
            List<string> BarLetters = bar.Get();

            FileReader reader = new FileReader();

            string text = reader.ParseFile("./assets/klingon-textoB.txt");
            
            Prepositions prepositions = new Prepositions(text);

            System.Console.WriteLine("Preposições no texto: " + prepositions.Get().Count);
        }
    }
}
