using System.Collections.Generic;
using System.Linq;
using KlingonAlphabet.Fixture;
using Xunit;

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
}