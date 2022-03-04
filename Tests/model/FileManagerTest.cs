using System.IO;
using System.Text;
using FileManager;
using Moq;
using Xunit;

namespace Tests
{
    public class FileManagerTest
    {
        [Fact]
        public void ParseFile_HelloWorldTXT_ReturnHelloWorld()
        {
            string path = "../../../TestFiles/helloWorld-sample.txt";
            string content = FileReader.ParseFile(path).ToLower();
            Assert.Equal("hello world",content);
        }

        [Fact]
        public void ParseFile_EmptyTXT_ReturnEmpty()
        {
            string path = "../../../TestFiles/empty-sample.txt";
            string content = FileReader.ParseFile(path);
            Assert.Equal("",content);
        }
    }
}