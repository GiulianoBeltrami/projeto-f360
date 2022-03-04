using System.Collections.Generic;
using System.Linq;

namespace TextHandler
{
    public static class TextFormatter
    {
        public static string[] LowerTextAndSplit(string text)
        {
            return text.ToLower().Split(' ');
        }
    }

    public static class TextProcessor
    {
        public static List<string> RemoveDuplicates(string[] text)
        {
            return text.Distinct().ToList();
        }
    }

}