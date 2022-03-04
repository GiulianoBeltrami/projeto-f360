using Tests;
using Xunit;
using TextHandler;
using System.Collections.Generic;

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

    public class TextProcessorTest
    {
        [Fact]
        public void RemoveDuplicates_TwoWords_ReturnOneWord()
        {
            List<string> expectedWordList = new List<string>() { "vwv" };

            string[] sampleWordList = { "vwv", "vwv"};

            List<string> actualWordList = TextProcessor.RemoveDuplicates(sampleWordList);

            Assert.Equal(expectedWordList, actualWordList);
        }
        
    }
}