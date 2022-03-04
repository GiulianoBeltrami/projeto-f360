
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

    public class KlingonFunctionFixture
    {
        public KlingonFunctionFactory KlingonFunctionFactory { get; private set; }
        public KlingonFunctionFixture()
        {
            KlingonFunctionFactory = new KlingonFunctionFactory();
        }
    }
}