using Interfaces.Klingon.Grammar;
using Interfaces.Klingon.Structure;
using Klingon.Alphabet.Grammar;
using Klingon.Alphabet.Structure;

namespace Klingon.Factory
{
    public class KlingonStructureFactory : IKlingonStructure
    {
        public Foo Foo { get => new Foo(); }
        public Bar Bar { get => new Bar(); }
    }

    public class KlingonGrammarFactory : IKlingonGrammar
    {
        public Prepositions Prepositions { get => new Prepositions(KlingonStructureFactory); }
        public Verbs Verbs { get => new Verbs(KlingonStructureFactory); }
        public KlingonStructureFactory KlingonStructureFactory { get => new KlingonStructureFactory(); }
    }
}