using Klingon.Numbers;
using Xunit;

namespace Tests
{
    public class NumbersTest
    {

        [Fact]
        public void Get_OneWord_ReturnOneNumber()
        {
            string testWord = "vwv";
            double expectNumber = 4852;

            Number number = new Number();
            double actualNumber = number.GetAll(testWord)[0];

            Assert.Equal(expectNumber, actualNumber);
        }

        [Fact]
        public void Get_TwoWords_ReturnOneNumber()
        {
            string testWord = "wvkzzjfj vwv";
            double expectCount = 1;

            Number number = new Number();
            double actualCount = number.GetBeautiful(testWord).Count;

            Assert.Equal(expectCount, actualCount);
        }

    }
}