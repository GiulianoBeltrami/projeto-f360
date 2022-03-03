using System;
using System.Collections.Generic;
using Xunit;
using KlingonAlphabet;
using System.Linq;

namespace Tests
{
    public class FooTest
    {
        [Fact]
        public void Get_SLFWK_ReturnSameLetters()
        {
            Foo foo = new Foo();
            List<string> expectedLetters = new List<string>() { "s", "l", "f", "w", "k" };

            List<string> fooLetters = foo.Get();

            Assert.Equal(expectedLetters, fooLetters);
        }

    }

    public class BarTest
    {

        [Fact]
        public void Get_Letters_ReturnLetters()
        {
            Foo foo = new Foo();
            List<string> fooLetters = foo.Get();
            Bar bar = new Bar();

            List<string> barLetters = bar.Get();
            bool IsBarContainFoo = barLetters.Any(x => fooLetters.Any(y => x == y));

            Assert.NotEmpty(barLetters);
            Assert.False(IsBarContainFoo);
        }
    }

    public class PrepositionsTest
    {
        [Fact]
        public void Get_OnePreposition_ReturnOnePreposition()
        {
            Prepositions prepositions = new Prepositions("vwv");
            List<string> expectedPrepositionList = new List<string>() { "vwv" };

            List<string> actualPrepositionList = prepositions.Get();

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

        [Fact]
        public void Get_Empty_ReturnEmpty()
        {
            Prepositions prepositions = new Prepositions("");
            List<string> expectedPrepositionList = new List<string>();

            List<string> actualPrepositionList = prepositions.Get();

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

        [Theory]
        [InlineData("vwv vwv")]
        [InlineData("vwv vwv vww vdv")]
        public void Get_TwoPrepostions_ReturnTwoPrepostions(string preposition)
        {

            List<string> expectedPrepositionList = new List<string>();
            expectedPrepositionList.Add("vwv");
            expectedPrepositionList.Add("vwv");
            Prepositions prepositions = new Prepositions(preposition);

            List<string> actualPrepositionList = prepositions.Get();

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

    }

    public class VerbsTest
    {
        
    }
}
