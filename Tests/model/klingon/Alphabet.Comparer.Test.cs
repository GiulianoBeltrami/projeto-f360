
using System;
using System.Collections.Generic;
using Klingon.Alphabet.Comparer;
using Xunit;

namespace Tests
{
    public class KlingonComparerTest
    {
        [Fact]
        public void Compare_TwoWords_ReturnsCorrectOrder()
        {

            List<string> expectedWordList = new List<string>();
            expectedWordList.Add("kkr");
            expectedWordList.Add("kkqrz");


            List<string> actualWordList = new List<string>();
            actualWordList.Add("kkqrz");
            actualWordList.Add("kkr");

            actualWordList.Sort(new KlingonComparer());

            Assert.Equal(expectedWordList, actualWordList);
        }

        [Fact]
        public void Compare_OneWord_ReturnSameWord()
        {
            List<string> expectedWordList = new List<string>();
            expectedWordList.Add("kkr");

            List<string> actualWordList = new List<string>();
            actualWordList.Add("kkr");

            actualWordList.Sort(new KlingonComparer());

            Assert.Equal(expectedWordList, actualWordList);
        }

        [Fact]
        public void Compare_ZeroWords_ReturnsEmpty()
        {
            List<string> expectedWordList = new List<string>();

            List<string> actualWordList = new List<string>();

            actualWordList.Sort(new KlingonComparer());

            Assert.Equal(expectedWordList, actualWordList);
        }
    }
}