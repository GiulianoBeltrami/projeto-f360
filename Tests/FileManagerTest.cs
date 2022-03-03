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
        public void ParseFile_Should_Return_HelloWord()
        {
            
            FileReader reader = new FileReader();
            string path = "../../../TestFiles/helloWord-sample.txt";
            string content = reader.ParseFile(path).ToLower();
            Assert.Equal("hello world",content);
        }

        [Fact]
        public void ParseFile_Should_Return_Empty()
        {
            
            FileReader reader = new FileReader();
            string path = "../../../TestFiles/empty-sample.txt";
            string content = reader.ParseFile(path);
            Assert.Equal("",content);
        }
    }
}