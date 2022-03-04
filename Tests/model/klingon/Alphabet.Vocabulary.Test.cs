using System.Collections.Generic;
using Xunit;
using Klingon.Alphabet.Vocabulary;
using Klingon.Alphabet.Comparer;

namespace Tests
{
    public class VocabularyTest
    {

        [Fact]
        public void Get_FourWords_ReturnTwoWithCorrectOrder()
        {
            string expectedWords = "kkr kkqrz";
            string sampleWords = "kkqrz kkqrz kkr kkr";

            Vocabulary vocabulary = new Vocabulary();
            string actualWords = vocabulary.Get(sampleWords);

            Assert.Equal(expectedWords, actualWords);
        }
    }
}