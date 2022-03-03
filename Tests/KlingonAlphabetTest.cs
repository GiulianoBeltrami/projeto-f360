using System.Collections.Generic;
using Xunit;
using System.Linq;
using Klingon.Alphabet.Functions;
using KlingonAlphabet.Fixture;

namespace Tests
{

    public class FooTest : IClassFixture<KlingonStructureFixture>
    {
        KlingonStructureFixture _fixture;
        public FooTest(KlingonStructureFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Get_FooLetters_ReturnSameLetters()
        {
            List<string> expected = new List<string>() { "s", "l", "f", "w", "k" };

            List<string> actual = _fixture.KlingonStructureFactory.Foo.Get();

            Assert.Equal(expected, actual);
        }

    }


    public class BarTest : IClassFixture<KlingonStructureFixture>
    {
        KlingonStructureFixture _fixture;
        public BarTest(KlingonStructureFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Get_BarLetters_ReturnLetters()
        {
            List<string> fooLetters = _fixture.KlingonStructureFactory.Foo.Get();
            List<string> barLetters = _fixture.KlingonStructureFactory.Bar.Get();

            bool IsBarContainFoo = barLetters.Any(x => fooLetters.Any(y => x == y));
            Assert.NotEmpty(barLetters);
            Assert.False(IsBarContainFoo);
        }
    }


    public class PrepositionsTest : IClassFixture<KlingonFunctionFixture>
    {
        private KlingonFunctionFixture _fixture;
        public PrepositionsTest(KlingonFunctionFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Get_OnePreposition_ReturnOnePreposition()
        {
            List<string> expectedPrepositionList = new List<string>() { "vwv" };

            List<string> actualPrepositionList = _fixture.KlingonFunctionFactory.Prepositions.Get("vwv");

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

        [Fact]
        public void Get_Empty_ReturnEmpty()
        {
            List<string> expectedPrepositionList = new List<string>();

            List<string> actualPrepositionList = _fixture.KlingonFunctionFactory.Prepositions.Get("");

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

            List<string> actualPrepositionList = _fixture.KlingonFunctionFactory.Prepositions.Get(preposition);

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

    }

    public class VerbsTest : IClassFixture<KlingonFunctionFixture>
    {
        KlingonFunctionFixture _fixture;
        public VerbsTest(KlingonFunctionFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Get_OneVerb_ReturnOneVerb()
        {
            //verbo em primeira pessoa
            string verb = "asdfgrews";
            //verbo em outros tempos
            //string verb = "ssdfgrews"

            List<string> expected = new List<string>();
            expected.Add(verb);

            List<string> actual = _fixture.KlingonFunctionFactory.Verbs.Get(verb);


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Get_TwoVerbs_ReturnTwoVerbs()
        {
            string verb = "asdfgrews";
            string verb2 = verb + " " + verb;

            List<string> expected = new List<string>();
            expected.Add(verb);
            expected.Add(verb);

            List<string> actual = _fixture.KlingonFunctionFactory.Verbs.Get(verb2);


            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Get_OneFirstPersonVerb_ReturnOneVerb()
        {
            string firstPersonVerb = "asdfgrews";

            List<string> expected = new List<string>();
            expected.Add(firstPersonVerb);

            List<string> actual = _fixture.KlingonFunctionFactory.Verbs.GetFirstPerson(firstPersonVerb);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFirstPerson_TwoVerbs_ReturnOneFirstPersonVerb()
        {
            string firstPersonVerb = "asdfgrews";
            string anotherPersonVerb = "ssdfgrews";
            string joinVerbs = firstPersonVerb + " " + anotherPersonVerb;

            List<string> expected = new List<string>();
            expected.Add(firstPersonVerb);

            List<string> actual = _fixture.KlingonFunctionFactory.Verbs.GetFirstPerson(joinVerbs);

            Assert.Equal(expected, actual);
        }
    }
}
