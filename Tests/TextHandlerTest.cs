using Tests;
using Xunit;
using TextHandler;

namespace Tests
{
    public class TextFormatterTest
    {
        [Fact]
        public void SplitText_HelloWorld_ReturnHelloWorld()
        {
            string text = "Hello World";
            string[] expected = {"hello","world"};
            TextFormatter formatter = new TextFormatter(text);

            string[] actual = formatter.SplitText();
            
            Assert.Equal(expected, actual);
        }

    }
}