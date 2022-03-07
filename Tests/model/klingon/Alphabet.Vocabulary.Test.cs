using System.Collections.Generic;
using Xunit;
using Klingon.Alphabet.Vocabulary;
using Klingon.Alphabet.Comparer;
using Klingon.Factory;

namespace Tests
{
    public class VocabularyTest
    {

        [Fact]
        public void Get_FourWords_ReturnTwoWithCorrectOrder()
        {
            string expectedWords = "kkr kkqrz";
            string sampleWords = "kkqrz kkqrz kkr kkr";

            KlingonVocabularyFactory vocabularyFactory = new KlingonVocabularyFactory();
            string actualWords = vocabularyFactory.Vocabulary.Get(sampleWords);

            Assert.Equal(expectedWords, actualWords);
        }
    }
}