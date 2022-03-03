namespace TextHandler
{
    public static class TextFormatter
    {
        public static string[] LowerTextAndSplit(string text)
        {
            return text.ToLower().Split(' ');
        }

    }
}