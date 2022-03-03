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
            
            FileReader reader = new FileReader();
            string path = "../../../TestFiles/helloWorld-sample.txt";
            string content = reader.ParseFile(path).ToLower();
            Assert.Equal("hello world",content);
        }

        [Fact]
        public void ParseFile_EmptyTXT_ReturnEmpty()
        {
            
            FileReader reader = new FileReader();
            string path = "../../../TestFiles/empty-sample.txt";
            string content = reader.ParseFile(path);
            Assert.Equal("",content);
        }
    }
}