namespace TextHandler
{
    public class TextFormatter
    {
        private string _text;
        public TextFormatter(string text)
        {
            _text = text.ToLower();
        }

        public string[] SplitText()
        {
            return _text.Split(' ');
        }

    }
}