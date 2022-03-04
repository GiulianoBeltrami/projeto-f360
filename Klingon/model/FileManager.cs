using System.IO;

namespace FileManager
{
    public static class FileReader
    {
        public static string ParseFile(string path)
        {
            string fileText = "";
            using (StreamReader reader = File.OpenText(path))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    fileText += line;
                }
            }
            return fileText;
        }
    }


}