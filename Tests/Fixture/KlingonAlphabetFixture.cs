
using Klingon.Factory;

namespace KlingonAlphabet.Fixture
{
    public class KlingonStructureFixture
    {
        public KlingonStructureFactory KlingonStructureFactory { get; private set; }
        public KlingonStructureFixture()
        {
            KlingonStructureFactory = new KlingonStructureFactory();
        }
    }

    public class KlingonGrammarFixture
    {
        public KlingonGrammarFactory KlingonGrammarFactory { get; private set; }
        public KlingonGrammarFixture()
        {
            KlingonGrammarFactory = new KlingonGrammarFactory();
        }
    }

}