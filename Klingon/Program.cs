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

            List<string> texts = new List<string>();

            IEnumerable<string> txtFiles = Directory.EnumerateFiles("./assets", "*.txt");
            
            foreach (string file in txtFiles)
            {
                texts.Add(reader.ParseFile(file));
            }

            string[] textA_List = texts[0].Split(' ');

            List<string> textA_Prepositions = new List<string>();

            foreach (string text in textA_List)
            {
                if (text.Length == 3 && BarLetters.Contains(text[2].ToString()) && !text.Contains("d"))
                {
                    textA_Prepositions.Add(text);
                }
            }

            System.Console.WriteLine(textA_Prepositions.Count);
        }
    }
}
