using System;
using System.Collections.Generic;
using Xunit;
using KlingonAlphabet;
using System.Linq;

namespace Tests
{
    public class KlingonAlphabetTest
    {
        [Fact]
        public void FooLetters_Should_Return_slfwk_String_List()
        {
            Foo foo = new Foo();
            List<string> expectedLetters = new List<string>() { "s", "l", "f", "w", "k" };

            List<string> fooLetters = foo.Get();

            Assert.Equal(expectedLetters, fooLetters);
        }

        [Fact]
        public void BarLetters_Should_Not_Return_List_With_Foo_Letters()
        {
            Foo foo = new Foo();
            List<string> fooLetters = foo.Get();
            Bar bar = new Bar();


            List<string> barLetters = bar.Get();

            Assert.False(barLetters.Any(x => fooLetters.Any(y => x == y)));
        }

        [Fact]
        public void GetPrepositions_Should_Return_VWV_List()
        {
            string testPreposition = "vwv";
            Prepositions prepositions = new Prepositions(testPreposition);
            List<string> expectedPrepositionList = new List<string>() { testPreposition };

            List<string> actualPrepositionList = prepositions.Get();

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

        [Fact]
        public void GetPrepositions_Should_Return_Empty_List()
        {
            string testPreposition = "vdv";
            Prepositions prepositions = new Prepositions(testPreposition);
            List<string> expectedPrepositionList = new List<string>();

            List<string> actualPrepositionList = prepositions.Get();

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }


        [Fact]
        public void GetPrepositions_Should_VWV_VWV_List()
        {
            string[] testPreposition = "vwv vwv".Split(' ');
            Prepositions prepositions = new Prepositions(testPreposition);
            List<string> expectedPrepositionList = new List<string>() { testPreposition };


            List<string> actualPrepositionList = prepositions.Get();

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }
    }
}
