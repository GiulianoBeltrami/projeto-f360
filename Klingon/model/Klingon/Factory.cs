using Interfaces.Klingon.Functions;
using Interfaces.Klingon.Structure;
using Klingon.Alphabet.Functions;
using Klingon.Alphabet.Structure;

namespace Klingon.Factory
{
    public class KlingonStructureFactory : IKlingonStructure
    {
        public Foo Foo { get => new Foo(); }
        public Bar Bar { get => new Bar(); }
    }

    public class KlingonFunctionFactory : IKlingonFunctions
    {
        public Prepositions Prepositions { get => new Prepositions(KlingonStructureFactory); }
        public Verbs Verbs { get => new Verbs(KlingonStructureFactory); }
        public KlingonStructureFactory KlingonStructureFactory { get => new KlingonStructureFactory(); }
    }
}