using System.Collections.Generic;
using Xunit;
using KlingonAlphabet.Fixture;

namespace Tests
{
    public class PrepositionsTest : IClassFixture<KlingonGrammarFixture>
    {
        private KlingonGrammarFixture _fixture;
        public PrepositionsTest(KlingonGrammarFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Get_OnePreposition_ReturnOnePreposition()
        {
            List<string> expectedPrepositionList = new List<string>() { "vwv" };

            List<string> actualPrepositionList = _fixture.KlingonGrammarFactory.Prepositions.Get("vwv");

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

        [Fact]
        public void Get_Empty_ReturnEmpty()
        {
            List<string> expectedPrepositionList = new List<string>();

            List<string> actualPrepositionList = _fixture.KlingonGrammarFactory.Prepositions.Get("");

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

            List<string> actualPrepositionList = _fixture.KlingonGrammarFactory.Prepositions.Get(preposition);

            Assert.Equal(expectedPrepositionList, actualPrepositionList);
        }

    }

    public class VerbsTest : IClassFixture<KlingonGrammarFixture>
    {
        KlingonGrammarFixture _fixture;
        public VerbsTest(KlingonGrammarFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Get_OneVerb_ReturnOneVerb()
        {
            string verb = "xmbhxlml";
            List<string> expected = new List<string>();
            expected.Add(verb);

            List<string> actual = _fixture.KlingonGrammarFactory.Verbs.Get(verb);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Get_TwoVerbs_ReturnTwoVerbs()
        {
            string verb = "fsdfgrews";
            string verb2 = verb + " " + verb;
            List<string> expected = new List<string>();
            expected.Add(verb);
            expected.Add(verb);

            List<string> actual = _fixture.KlingonGrammarFactory.Verbs.Get(verb2);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Get_OneFirstPersonVerb_ReturnOneVerb()
        {
            string firstPersonVerb = "dsdfgrews";
            List<string> expected = new List<string>();
            expected.Add(firstPersonVerb);

            List<string> actual = _fixture.KlingonGrammarFactory.Verbs.GetFirstPerson(firstPersonVerb);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFirstPerson_TwoVerbs_ReturnOneFirstPersonVerb()
        {
            string firstPersonVerb = "dsdfgrews";
            string anotherPersonVerb = "ssdfgrews";
            string joinVerbs = firstPersonVerb + " " + anotherPersonVerb;
            List<string> expected = new List<string>();
            expected.Add(firstPersonVerb);

            List<string> actual = _fixture.KlingonGrammarFactory.Verbs.GetFirstPerson(joinVerbs);

            Assert.Equal(expected, actual);
        }
    }
}
