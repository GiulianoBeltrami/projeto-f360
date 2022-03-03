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

            string[] actual = TextFormatter.LowerTextAndSplit(text);
            
            Assert.Equal(expected, actual);
        }

    }
}